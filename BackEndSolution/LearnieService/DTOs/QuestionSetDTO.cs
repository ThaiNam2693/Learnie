namespace LearnieService.DTOs
{
	public class QuestionSetDTO
	{
		public string QuestSetName { get; set; }

	}

    public class CreateQuestionSetRequest
    {
        public string QuestionSet { get; set; }
    }
}
