using System.Text.Json.Serialization;

namespace MAX.Bot.Interfaces.Models;

/// <summary>
/// Модель сообщения
/// </summary>
public record Message
{
    /// <summary>
    /// Сообщение в чате
    /// </summary>
    [JsonPropertyName("sender")]
    public User? Sender { get; set; }

    /// <summary>
    /// Содержимое сообщения. Текст + вложения. Может быть null, 
    /// если сообщение содержит только пересланное сообщение
    /// </summary>
    [JsonPropertyName("body")]
    public MessageBody? Body { get; set; }
}