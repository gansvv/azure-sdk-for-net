// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ConversationsModelFactory
    {
        /// <summary> Initializes a new instance of AnalyzeConversationResult. </summary>
        /// <param name="query"> The conversation utterance given by the caller. </param>
        /// <param name="detectedLanguage"> The system detected language for the query. </param>
        /// <param name="prediction"> The prediction result of a conversation project. </param>
        /// <returns> A new <see cref="Models.AnalyzeConversationResult"/> instance for mocking. </returns>
        public static AnalyzeConversationResult AnalyzeConversationResult(string query = null, string detectedLanguage = null, BasePrediction prediction = null)
        {
            return new AnalyzeConversationResult(query, detectedLanguage, prediction);
        }

        /// <summary> Initializes a new instance of BasePrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <returns> A new <see cref="Models.BasePrediction"/> instance for mocking. </returns>
        public static BasePrediction BasePrediction(ProjectKind projectKind = default, string topIntent = null)
        {
            return new BasePrediction(projectKind, topIntent);
        }

        /// <summary> Initializes a new instance of NoneLinkedTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        /// <returns> A new <see cref="Models.NoneLinkedTargetIntentResult"/> instance for mocking. </returns>
        public static NoneLinkedTargetIntentResult NoneLinkedTargetIntentResult(TargetKind targetKind = default, string apiVersion = null, double confidenceScore = default, ConversationResult result = null)
        {
            return new NoneLinkedTargetIntentResult(targetKind, apiVersion, confidenceScore, result);
        }

        /// <summary> Initializes a new instance of ConversationResult. </summary>
        /// <param name="query"> The same query given in request. </param>
        /// <param name="detectedLanguage"> The detected language from the query. </param>
        /// <param name="prediction"> The predicted result for the query. </param>
        /// <returns> A new <see cref="Models.ConversationResult"/> instance for mocking. </returns>
        public static ConversationResult ConversationResult(string query = null, string detectedLanguage = null, ConversationPrediction prediction = null)
        {
            return new ConversationResult(query, detectedLanguage, prediction);
        }

        /// <summary> Initializes a new instance of ConversationPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> The intent classification results. </param>
        /// <param name="entities"> The entity extraction results. </param>
        /// <returns> A new <see cref="Models.ConversationPrediction"/> instance for mocking. </returns>
        public static ConversationPrediction ConversationPrediction(ProjectKind projectKind = default, string topIntent = null, IEnumerable<ConversationIntent> intents = null, IEnumerable<ConversationEntity> entities = null)
        {
            intents ??= new List<ConversationIntent>();
            entities ??= new List<ConversationEntity>();

            return new ConversationPrediction(projectKind, topIntent, intents?.ToList(), entities?.ToList());
        }

        /// <summary> Initializes a new instance of ConversationIntent. </summary>
        /// <param name="category"> A predicted class. </param>
        /// <param name="confidenceScore"> The confidence score of the class from 0.0 to 1.0. </param>
        /// <returns> A new <see cref="Models.ConversationIntent"/> instance for mocking. </returns>
        public static ConversationIntent ConversationIntent(string category = null, float confidenceScore = default)
        {
            return new ConversationIntent(category, confidenceScore);
        }

        /// <summary> Initializes a new instance of ConversationEntity. </summary>
        /// <param name="category"> The entity category. </param>
        /// <param name="text"> The predicted entity text. </param>
        /// <param name="offset"> The starting index of this entity in the query. </param>
        /// <param name="length"> The length of the text. </param>
        /// <param name="confidenceScore"> The entity confidence score. </param>
        /// <param name="listKeys"> List of keys. </param>
        /// <returns> A new <see cref="Models.ConversationEntity"/> instance for mocking. </returns>
        public static ConversationEntity ConversationEntity(string category = null, string text = null, int offset = default, int length = default, float confidenceScore = default, IEnumerable<string> listKeys = null)
        {
            listKeys ??= new List<string>();

            return new ConversationEntity(category, text, offset, length, confidenceScore, listKeys?.ToList());
        }

        /// <summary> Initializes a new instance of TargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <returns> A new <see cref="Models.TargetIntentResult"/> instance for mocking. </returns>
        public static TargetIntentResult TargetIntentResult(TargetKind targetKind = default, string apiVersion = null, double confidenceScore = default)
        {
            return new TargetIntentResult(targetKind, apiVersion, confidenceScore);
        }

        /// <summary> Initializes a new instance of OrchestratorPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> A dictionary that contains all intents. A key is an intent name and a value is its confidence score and target type. The top intent&apos;s value also contains the actual response from the target project. </param>
        /// <returns> A new <see cref="Models.OrchestratorPrediction"/> instance for mocking. </returns>
        public static OrchestratorPrediction OrchestratorPrediction(ProjectKind projectKind = default, string topIntent = null, IReadOnlyDictionary<string, TargetIntentResult> intents = null)
        {
            intents ??= new Dictionary<string, TargetIntentResult>();

            return new OrchestratorPrediction(projectKind, topIntent, intents);
        }

        /// <summary> Initializes a new instance of ConversationTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        /// <returns> A new <see cref="Models.ConversationTargetIntentResult"/> instance for mocking. </returns>
        public static ConversationTargetIntentResult ConversationTargetIntentResult(TargetKind targetKind = default, string apiVersion = null, double confidenceScore = default, ConversationResult result = null)
        {
            return new ConversationTargetIntentResult(targetKind, apiVersion, confidenceScore, result);
        }

        /// <summary> Initializes a new instance of LuisTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a LUIS Generally Available application. </param>
        /// <returns> A new <see cref="Models.LuisTargetIntentResult"/> instance for mocking. </returns>
        public static LuisTargetIntentResult LuisTargetIntentResult(TargetKind targetKind = default, string apiVersion = null, double confidenceScore = default, object result = null)
        {
            return new LuisTargetIntentResult(targetKind, apiVersion, confidenceScore, result);
        }

        /// <summary> Initializes a new instance of QuestionAnsweringTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The generated answer by a Question Answering KB. </param>
        /// <returns> A new <see cref="Models.QuestionAnsweringTargetIntentResult"/> instance for mocking. </returns>
        public static QuestionAnsweringTargetIntentResult QuestionAnsweringTargetIntentResult(TargetKind targetKind = default, string apiVersion = null, double confidenceScore = default, KnowledgeBaseAnswers result = null)
        {
            return new QuestionAnsweringTargetIntentResult(targetKind, apiVersion, confidenceScore, result);
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswers. </summary>
        /// <param name="answers"> Represents Answer Result list. </param>
        /// <returns> A new <see cref="Models.KnowledgeBaseAnswers"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswers KnowledgeBaseAnswers(IEnumerable<KnowledgeBaseAnswer> answers = null)
        {
            answers ??= new List<KnowledgeBaseAnswer>();

            return new KnowledgeBaseAnswers(answers?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswer. </summary>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <param name="answer"> Answer text. </param>
        /// <param name="confidenceScore"> Answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> ID of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> Metadata associated with the answer, useful to categorize or filter question answers. </param>
        /// <param name="dialog"> Dialog associated with Answer. </param>
        /// <param name="answerSpan"> Answer span object of QnA with respect to user&apos;s question. </param>
        /// <returns> A new <see cref="Models.KnowledgeBaseAnswer"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswer KnowledgeBaseAnswer(IEnumerable<string> questions = null, string answer = null, double? confidenceScore = null, int? id = null, string source = null, IReadOnlyDictionary<string, string> metadata = null, KnowledgeBaseAnswerDialog dialog = null, AnswerSpan answerSpan = null)
        {
            questions ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new KnowledgeBaseAnswer(questions?.ToList(), answer, confidenceScore, id, source, metadata, dialog, answerSpan);
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswerDialog. </summary>
        /// <param name="isContextOnly"> To mark if a prompt is relevant only with a previous question or not. If true, do not include this QnA as search result for queries without context; otherwise, if false, ignores context and includes this QnA in search result. </param>
        /// <param name="prompts"> List of prompts associated with the answer. </param>
        /// <returns> A new <see cref="Models.KnowledgeBaseAnswerDialog"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerDialog KnowledgeBaseAnswerDialog(bool? isContextOnly = null, IEnumerable<KnowledgeBaseAnswerPrompt> prompts = null)
        {
            prompts ??= new List<KnowledgeBaseAnswerPrompt>();

            return new KnowledgeBaseAnswerDialog(isContextOnly, prompts?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswerPrompt. </summary>
        /// <param name="displayOrder"> Index of the prompt - used in ordering of the prompts. </param>
        /// <param name="qnaId"> QnA ID corresponding to the prompt. </param>
        /// <param name="displayText"> Text displayed to represent a follow up question prompt. </param>
        /// <returns> A new <see cref="Models.KnowledgeBaseAnswerPrompt"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerPrompt KnowledgeBaseAnswerPrompt(int? displayOrder = null, int? qnaId = null, string displayText = null)
        {
            return new KnowledgeBaseAnswerPrompt(displayOrder, qnaId, displayText);
        }

        /// <summary> Initializes a new instance of AnswerSpan. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidenceScore"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        /// <returns> A new <see cref="Models.AnswerSpan"/> instance for mocking. </returns>
        public static AnswerSpan AnswerSpan(string text = null, double? confidenceScore = null, int? offset = null, int? length = null)
        {
            return new AnswerSpan(text, confidenceScore, offset, length);
        }
    }
}
