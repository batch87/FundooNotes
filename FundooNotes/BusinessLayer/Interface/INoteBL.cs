﻿using CommonLayer.Notes;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface INoteBL
    {
        Task AddNote(int Userid, NotePostModel notePost);

        bool UpdateNote(int noteId, NotePostModel notePost);

        Task<List<Notes>> GetAllNotes(int Userid);


        bool DeleteNote(int noteId);

        Task<List<Notes>> changeColor(int noteId, string color);

        Task ArchieveNote(int noteId);

        bool IsPin(int noteId);

        Task TrashNote(int noteId);
    }
}
