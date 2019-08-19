namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class PictureInfoDBContext : DbContext
    {
        public PictureInfoDBContext()
            : base("name=PictureInfoDBContext")
        {
        }

        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Picture>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Pictures)
                .Map(m => m.ToTable("PictureTags"));
        }

        public virtual void AddPicture(string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                    throw new ArgumentNullException();

                Pictures.Add(new Picture { Path = path });
            }
            catch (Exception e)
            {
                throw e;
            }

            SaveChanges();
        }
        public virtual Picture GetPicture(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException();

            Picture picture = Pictures.FirstOrDefault(p => p.Path == path);

            if (picture == null)
                return null;

            return picture;
        }
        public virtual Picture FindPicture(int number)
        {
            if (number < 1)
                throw new ArgumentException();

            Picture picture = Pictures.Find(number);

            if (picture == null)
                return null;

            return picture;
        }
        public virtual List<Picture> GetAllPictures()
        {
            List<Picture> tags = Pictures.ToList();
            return tags;
        }
        public virtual void ChangePicturePath(Picture pictureToChange, string newPath)
        {
            Picture picture = null;

            IEnumerable<string> query = from pict in Pictures
                                        where pict.Path == pictureToChange.Path
                                        select pictureToChange.Path;

            if (query.Count() != 1 && !query.Contains(pictureToChange.Path))
                throw new ArgumentException("Dublicated picture path or DB does not containce current path");

            System.Linq.Expressions.Expression<Func<Picture, bool>> predicate = pict => pict.Path == pictureToChange.Path;
            picture = Pictures.FirstOrDefault(predicate);

            picture.Path = newPath;

            Entry(picture).State = EntityState.Modified;
            SaveChanges();
        }
        public virtual void DeletePicture(Picture pictureToDelete)
        {
            Picture picture = null;
            try
            {
                picture = Pictures.FirstOrDefault(pict => pict.Path == pictureToDelete.Path);
            }
            catch (ArgumentException e)
            {
                throw e;
            }

            Pictures.Remove(picture);
            SaveChanges();
        }
        public virtual void ClearPictures()
        {
            foreach (var pict in Pictures)
            {
                Pictures.Remove(pict);
            }

        }

        //---------------------------------------------//
        public virtual void AddTag(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentNullException();

                Tags.Add(new Tag { Name = name });
            }
            catch (Exception e)
            {
                throw e;
            }
            SaveChanges();
        }
        public virtual Tag GetTag(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            Tag tag = Tags.FirstOrDefault(t => t.Name == name);

            if (tag == null)
                return null;

            return tag;
        }
        public virtual Tag FindTag(int number)
        {
            if (number < 1)
                throw new ArgumentException();

            Tag tag = Tags.Find(number);

            if (tag == null)
                return null;

            return tag;
        }
        public virtual List<Tag> GetAllTags()
        {
            List<Tag> tags = Tags.ToList();
            return tags;
        }
        public virtual void ChangeTagName(Tag tagToChange, string newName)
        {
            Tag tag = null;
            try
            {
                tag = Tags.FirstOrDefault(t => t.Name == tagToChange.Name);
            }
            catch (Exception e)
            {
                throw e;
            }
            if (tag == null)
            {
                return;
            }

            tag.Name = newName;

            Entry(tag).State = EntityState.Modified;
            SaveChanges();
        }
        public virtual void DeleteTag(Tag tagToDelete)
        {
            Tag tag = null;
            try
            {
                tag = Tags.FirstOrDefault(t => t.Name == tagToDelete.Name);
            }
            catch (ArgumentException e)
            {
                throw e;
            }

            Tags.Remove(tag);
            SaveChanges();
        }
        public virtual void ClearTags()
        {
            foreach (var tag in Tags)
            {
                Tags.Remove(tag);
            }
        }

        //---------------------------------------------//
        public virtual void AddTagsToPicture(string path, params Tag[] NewTags)
        {
            if (NewTags is null)
            {
                throw new ArgumentNullException(nameof(NewTags));
            }

            Picture picture = Pictures.FirstOrDefault(pict => pict.Path == path);
            List<Tag> allTags = Tags.ToList();

            foreach (var newTag in NewTags)
            {
                if (!picture.Tags.Contains(newTag) && !allTags.Contains(newTag))
                {
                    Tag t = allTags.Find(ta => ta.Name == newTag.Name);
                    picture.Tags.Add(t);
                }
            }

            Entry(picture).State = EntityState.Modified;
            SaveChanges();
        }
        public virtual void RemoveTagsFromPicture(string path, params Tag[] RemoveTags)
        {
            if (RemoveTags is null)
            {
                throw new ArgumentNullException(nameof(RemoveTags));
            }

            Picture picture = Pictures.FirstOrDefault(pict => pict.Path == path);
            List<Tag> allTags = Tags.ToList();

            foreach (var removeTag in RemoveTags)
            {
                if (!picture.Tags.Contains(removeTag) && !allTags.Contains(removeTag))
                {
                    Tag t = allTags.Find(ta => ta.Name == removeTag.Name);
                    picture.Tags.Remove(t);
                }
            }

            Entry(picture).State = EntityState.Modified;
            SaveChanges();
        }
    }
}
