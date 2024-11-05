using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LearnieService.Migrations
{
    /// <inheritdoc />
    public partial class Inil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Birthday", "Fullname", "Subcription", "SubcriptionExpiredAt", "SubcriptionStartAt", "UserEmail", "UserPassword" },
                values: new object[,]
                {
                    { 1, "1990-01-01", "User One", true, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user1@example.com", "password1" },
                    { 2, "1992-02-02", "User Two", false, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user2@example.com", "password2" },
                    { 3, "1994-03-03", "User Three", true, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user3@example.com", "password3" },
                    { 4, "1996-04-04", "User Four", false, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user4@example.com", "password4" },
                    { 5, "1998-05-05", "User Five", true, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user5@example.com", "password5" },
                    { 6, "2000-06-06", "User Six", false, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user6@example.com", "password6" },
                    { 7, "2002-07-07", "User Seven", true, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user7@example.com", "password7" },
                    { 8, "2004-08-08", "User Eight", false, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user8@example.com", "password8" },
                    { 9, "2006-09-09", "User Nine", true, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user9@example.com", "password9" },
                    { 10, "2008-10-10", "User Ten", false, new DateOnly(2024, 11, 5), new DateOnly(2024, 11, 5), "user10@example.com", "password10" }
                });

            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "QuestionSetID", "CreatedAt", "QuestSetName", "UserID" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 11, 4), "Question Set 1", 2 },
                    { 2, new DateOnly(2024, 11, 3), "Question Set 2", 3 },
                    { 3, new DateOnly(2024, 11, 2), "Question Set 3", 4 },
                    { 4, new DateOnly(2024, 11, 1), "Question Set 4", 5 },
                    { 5, new DateOnly(2024, 10, 31), "Question Set 5", 6 },
                    { 6, new DateOnly(2024, 10, 30), "Question Set 6", 7 },
                    { 7, new DateOnly(2024, 10, 29), "Question Set 7", 8 },
                    { 8, new DateOnly(2024, 10, 28), "Question Set 8", 9 },
                    { 9, new DateOnly(2024, 10, 27), "Question Set 9", 10 },
                    { 10, new DateOnly(2024, 10, 26), "Question Set 10", 1 },
                    { 11, new DateOnly(2024, 10, 25), "Question Set 11", 2 },
                    { 12, new DateOnly(2024, 10, 24), "Question Set 12", 3 },
                    { 13, new DateOnly(2024, 10, 23), "Question Set 13", 4 },
                    { 14, new DateOnly(2024, 10, 22), "Question Set 14", 5 },
                    { 15, new DateOnly(2024, 10, 21), "Question Set 15", 6 },
                    { 16, new DateOnly(2024, 10, 20), "Question Set 16", 7 },
                    { 17, new DateOnly(2024, 10, 19), "Question Set 17", 8 },
                    { 18, new DateOnly(2024, 10, 18), "Question Set 18", 9 },
                    { 19, new DateOnly(2024, 10, 17), "Question Set 19", 10 },
                    { 20, new DateOnly(2024, 10, 16), "Question Set 20", 1 },
                    { 21, new DateOnly(2024, 10, 15), "Question Set 21", 2 },
                    { 22, new DateOnly(2024, 10, 14), "Question Set 22", 3 },
                    { 23, new DateOnly(2024, 10, 13), "Question Set 23", 4 },
                    { 24, new DateOnly(2024, 10, 12), "Question Set 24", 5 },
                    { 25, new DateOnly(2024, 10, 11), "Question Set 25", 6 },
                    { 26, new DateOnly(2024, 10, 10), "Question Set 26", 7 },
                    { 27, new DateOnly(2024, 10, 9), "Question Set 27", 8 },
                    { 28, new DateOnly(2024, 10, 8), "Question Set 28", 9 },
                    { 29, new DateOnly(2024, 10, 7), "Question Set 29", 10 },
                    { 30, new DateOnly(2024, 10, 6), "Question Set 30", 1 },
                    { 31, new DateOnly(2024, 10, 5), "Question Set 31", 2 },
                    { 32, new DateOnly(2024, 10, 4), "Question Set 32", 3 },
                    { 33, new DateOnly(2024, 10, 3), "Question Set 33", 4 },
                    { 34, new DateOnly(2024, 10, 2), "Question Set 34", 5 },
                    { 35, new DateOnly(2024, 10, 1), "Question Set 35", 6 },
                    { 36, new DateOnly(2024, 9, 30), "Question Set 36", 7 },
                    { 37, new DateOnly(2024, 9, 29), "Question Set 37", 8 },
                    { 38, new DateOnly(2024, 9, 28), "Question Set 38", 9 },
                    { 39, new DateOnly(2024, 9, 27), "Question Set 39", 10 },
                    { 40, new DateOnly(2024, 9, 26), "Question Set 40", 1 },
                    { 41, new DateOnly(2024, 9, 25), "Question Set 41", 2 },
                    { 42, new DateOnly(2024, 9, 24), "Question Set 42", 3 },
                    { 43, new DateOnly(2024, 9, 23), "Question Set 43", 4 },
                    { 44, new DateOnly(2024, 9, 22), "Question Set 44", 5 },
                    { 45, new DateOnly(2024, 9, 21), "Question Set 45", 6 },
                    { 46, new DateOnly(2024, 9, 20), "Question Set 46", 7 },
                    { 47, new DateOnly(2024, 9, 19), "Question Set 47", 8 },
                    { 48, new DateOnly(2024, 9, 18), "Question Set 48", 9 },
                    { 49, new DateOnly(2024, 9, 17), "Question Set 49", 10 },
                    { 50, new DateOnly(2024, 9, 16), "Question Set 50", 1 }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteID", "NoteContent", "QuestionSetID", "UserEmail", "UserID" },
                values: new object[,]
                {
                    { 1, "This is note 1", 2, "user2@example.com", null },
                    { 2, "This is note 2", 3, "user3@example.com", null },
                    { 3, "This is note 3", 4, "user4@example.com", null },
                    { 4, "This is note 4", 5, "user5@example.com", null },
                    { 5, "This is note 5", 6, "user6@example.com", null },
                    { 6, "This is note 6", 7, "user7@example.com", null },
                    { 7, "This is note 7", 8, "user8@example.com", null },
                    { 8, "This is note 8", 9, "user9@example.com", null },
                    { 9, "This is note 9", 10, "user10@example.com", null },
                    { 10, "This is note 10", 11, "user1@example.com", null },
                    { 11, "This is note 11", 12, "user2@example.com", null },
                    { 12, "This is note 12", 13, "user3@example.com", null },
                    { 13, "This is note 13", 14, "user4@example.com", null },
                    { 14, "This is note 14", 15, "user5@example.com", null },
                    { 15, "This is note 15", 16, "user6@example.com", null },
                    { 16, "This is note 16", 17, "user7@example.com", null },
                    { 17, "This is note 17", 18, "user8@example.com", null },
                    { 18, "This is note 18", 19, "user9@example.com", null },
                    { 19, "This is note 19", 20, "user10@example.com", null },
                    { 20, "This is note 20", 21, "user1@example.com", null },
                    { 21, "This is note 21", 22, "user2@example.com", null },
                    { 22, "This is note 22", 23, "user3@example.com", null },
                    { 23, "This is note 23", 24, "user4@example.com", null },
                    { 24, "This is note 24", 25, "user5@example.com", null },
                    { 25, "This is note 25", 26, "user6@example.com", null },
                    { 26, "This is note 26", 27, "user7@example.com", null },
                    { 27, "This is note 27", 28, "user8@example.com", null },
                    { 28, "This is note 28", 29, "user9@example.com", null },
                    { 29, "This is note 29", 30, "user10@example.com", null },
                    { 30, "This is note 30", 31, "user1@example.com", null },
                    { 31, "This is note 31", 32, "user2@example.com", null },
                    { 32, "This is note 32", 33, "user3@example.com", null },
                    { 33, "This is note 33", 34, "user4@example.com", null },
                    { 34, "This is note 34", 35, "user5@example.com", null },
                    { 35, "This is note 35", 36, "user6@example.com", null },
                    { 36, "This is note 36", 37, "user7@example.com", null },
                    { 37, "This is note 37", 38, "user8@example.com", null },
                    { 38, "This is note 38", 39, "user9@example.com", null },
                    { 39, "This is note 39", 40, "user10@example.com", null },
                    { 40, "This is note 40", 41, "user1@example.com", null },
                    { 41, "This is note 41", 42, "user2@example.com", null },
                    { 42, "This is note 42", 43, "user3@example.com", null },
                    { 43, "This is note 43", 44, "user4@example.com", null },
                    { 44, "This is note 44", 45, "user5@example.com", null },
                    { 45, "This is note 45", 46, "user6@example.com", null },
                    { 46, "This is note 46", 47, "user7@example.com", null },
                    { 47, "This is note 47", 48, "user8@example.com", null },
                    { 48, "This is note 48", 49, "user9@example.com", null },
                    { 49, "This is note 49", 50, "user10@example.com", null },
                    { 50, "This is note 50", 1, "user1@example.com", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionContent", "QuestionDescription", "QuestionSetID" },
                values: new object[,]
                {
                    { 1, "What is question 1?", "Description for question 1", 2 },
                    { 2, "What is question 2?", "Description for question 2", 3 },
                    { 3, "What is question 3?", "Description for question 3", 4 },
                    { 4, "What is question 4?", "Description for question 4", 5 },
                    { 5, "What is question 5?", "Description for question 5", 6 },
                    { 6, "What is question 6?", "Description for question 6", 7 },
                    { 7, "What is question 7?", "Description for question 7", 8 },
                    { 8, "What is question 8?", "Description for question 8", 9 },
                    { 9, "What is question 9?", "Description for question 9", 10 },
                    { 10, "What is question 10?", "Description for question 10", 11 },
                    { 11, "What is question 11?", "Description for question 11", 12 },
                    { 12, "What is question 12?", "Description for question 12", 13 },
                    { 13, "What is question 13?", "Description for question 13", 14 },
                    { 14, "What is question 14?", "Description for question 14", 15 },
                    { 15, "What is question 15?", "Description for question 15", 16 },
                    { 16, "What is question 16?", "Description for question 16", 17 },
                    { 17, "What is question 17?", "Description for question 17", 18 },
                    { 18, "What is question 18?", "Description for question 18", 19 },
                    { 19, "What is question 19?", "Description for question 19", 20 },
                    { 20, "What is question 20?", "Description for question 20", 21 },
                    { 21, "What is question 21?", "Description for question 21", 22 },
                    { 22, "What is question 22?", "Description for question 22", 23 },
                    { 23, "What is question 23?", "Description for question 23", 24 },
                    { 24, "What is question 24?", "Description for question 24", 25 },
                    { 25, "What is question 25?", "Description for question 25", 26 },
                    { 26, "What is question 26?", "Description for question 26", 27 },
                    { 27, "What is question 27?", "Description for question 27", 28 },
                    { 28, "What is question 28?", "Description for question 28", 29 },
                    { 29, "What is question 29?", "Description for question 29", 30 },
                    { 30, "What is question 30?", "Description for question 30", 31 },
                    { 31, "What is question 31?", "Description for question 31", 32 },
                    { 32, "What is question 32?", "Description for question 32", 33 },
                    { 33, "What is question 33?", "Description for question 33", 34 },
                    { 34, "What is question 34?", "Description for question 34", 35 },
                    { 35, "What is question 35?", "Description for question 35", 36 },
                    { 36, "What is question 36?", "Description for question 36", 37 },
                    { 37, "What is question 37?", "Description for question 37", 38 },
                    { 38, "What is question 38?", "Description for question 38", 39 },
                    { 39, "What is question 39?", "Description for question 39", 40 },
                    { 40, "What is question 40?", "Description for question 40", 41 },
                    { 41, "What is question 41?", "Description for question 41", 42 },
                    { 42, "What is question 42?", "Description for question 42", 43 },
                    { 43, "What is question 43?", "Description for question 43", 44 },
                    { 44, "What is question 44?", "Description for question 44", 45 },
                    { 45, "What is question 45?", "Description for question 45", 46 },
                    { 46, "What is question 46?", "Description for question 46", 47 },
                    { 47, "What is question 47?", "Description for question 47", 48 },
                    { 48, "What is question 48?", "Description for question 48", 49 },
                    { 49, "What is question 49?", "Description for question 49", 50 },
                    { 50, "What is question 50?", "Description for question 50", 1 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerID", "AnswerContent", "IsRightAnswer", "QuestionID" },
                values: new object[,]
                {
                    { 1, 1, false, 2 },
                    { 2, 2, true, 3 },
                    { 3, 3, false, 4 },
                    { 4, 4, true, 5 },
                    { 5, 5, false, 6 },
                    { 6, 6, true, 7 },
                    { 7, 7, false, 8 },
                    { 8, 8, true, 9 },
                    { 9, 9, false, 10 },
                    { 10, 10, true, 11 },
                    { 11, 11, false, 12 },
                    { 12, 12, true, 13 },
                    { 13, 13, false, 14 },
                    { 14, 14, true, 15 },
                    { 15, 15, false, 16 },
                    { 16, 16, true, 17 },
                    { 17, 17, false, 18 },
                    { 18, 18, true, 19 },
                    { 19, 19, false, 20 },
                    { 20, 20, true, 21 },
                    { 21, 21, false, 22 },
                    { 22, 22, true, 23 },
                    { 23, 23, false, 24 },
                    { 24, 24, true, 25 },
                    { 25, 25, false, 26 },
                    { 26, 26, true, 27 },
                    { 27, 27, false, 28 },
                    { 28, 28, true, 29 },
                    { 29, 29, false, 30 },
                    { 30, 30, true, 31 },
                    { 31, 31, false, 32 },
                    { 32, 32, true, 33 },
                    { 33, 33, false, 34 },
                    { 34, 34, true, 35 },
                    { 35, 35, false, 36 },
                    { 36, 36, true, 37 },
                    { 37, 37, false, 38 },
                    { 38, 38, true, 39 },
                    { 39, 39, false, 40 },
                    { 40, 40, true, 41 },
                    { 41, 41, false, 42 },
                    { 42, 42, true, 43 },
                    { 43, 43, false, 44 },
                    { 44, 44, true, 45 },
                    { 45, 45, false, 46 },
                    { 46, 46, true, 47 },
                    { 47, 47, false, 48 },
                    { 48, 48, true, 49 },
                    { 49, 49, false, 50 },
                    { 50, 50, true, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "QuestionSetID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 10);
        }
    }
}
