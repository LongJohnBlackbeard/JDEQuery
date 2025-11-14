using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F410014D - .
/// </summary>
public class F410014D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T8TMPL.
        /// </summary>
        public const string T8TMPL = "T8TMPL";

        /// <summary>
        /// T8MCU.
        /// </summary>
        public const string T8MCU = "T8MCU";

        /// <summary>
        /// T8LNGP.
        /// </summary>
        public const string T8LNGP = "T8LNGP";

        /// <summary>
        /// T8TDES.
        /// </summary>
        public const string T8TDES = "T8TDES";

        /// <summary>
        /// T8SGD1.
        /// </summary>
        public const string T8SGD1 = "T8SGD1";

        /// <summary>
        /// T8SGD2.
        /// </summary>
        public const string T8SGD2 = "T8SGD2";

        /// <summary>
        /// T8SGD3.
        /// </summary>
        public const string T8SGD3 = "T8SGD3";

        /// <summary>
        /// T8SGD4.
        /// </summary>
        public const string T8SGD4 = "T8SGD4";

        /// <summary>
        /// T8SGD5.
        /// </summary>
        public const string T8SGD5 = "T8SGD5";

        /// <summary>
        /// T8SGD6.
        /// </summary>
        public const string T8SGD6 = "T8SGD6";

        /// <summary>
        /// T8SGD7.
        /// </summary>
        public const string T8SGD7 = "T8SGD7";

        /// <summary>
        /// T8SGD8.
        /// </summary>
        public const string T8SGD8 = "T8SGD8";

        /// <summary>
        /// T8SGD9.
        /// </summary>
        public const string T8SGD9 = "T8SGD9";

        /// <summary>
        /// T8SGD0.
        /// </summary>
        public const string T8SGD0 = "T8SGD0";

        /// <summary>
        /// T8USER.
        /// </summary>
        public const string T8USER = "T8USER";

        /// <summary>
        /// T8PID.
        /// </summary>
        public const string T8PID = "T8PID";

        /// <summary>
        /// T8JOBN.
        /// </summary>
        public const string T8JOBN = "T8JOBN";

        /// <summary>
        /// T8UPMJ.
        /// </summary>
        public const string T8UPMJ = "T8UPMJ";

        /// <summary>
        /// T8TDAY.
        /// </summary>
        public const string T8TDAY = "T8TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F410014D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T8TMPL", "T8TMPL", JdeDataType.String, 40, true, true),
        new JdeField("T8MCU", "T8MCU", JdeDataType.String, 24, true, true),
        new JdeField("T8LNGP", "T8LNGP", JdeDataType.String, 4, true, true),
        new JdeField("T8TDES", "T8TDES", JdeDataType.String, 60),
        new JdeField("T8SGD1", "T8SGD1", JdeDataType.String, 30),
        new JdeField("T8SGD2", "T8SGD2", JdeDataType.String, 30),
        new JdeField("T8SGD3", "T8SGD3", JdeDataType.String, 30),
        new JdeField("T8SGD4", "T8SGD4", JdeDataType.String, 30),
        new JdeField("T8SGD5", "T8SGD5", JdeDataType.String, 30),
        new JdeField("T8SGD6", "T8SGD6", JdeDataType.String, 30),
        new JdeField("T8SGD7", "T8SGD7", JdeDataType.String, 30),
        new JdeField("T8SGD8", "T8SGD8", JdeDataType.String, 30),
        new JdeField("T8SGD9", "T8SGD9", JdeDataType.String, 30),
        new JdeField("T8SGD0", "T8SGD0", JdeDataType.String, 30),
        new JdeField("T8USER", "T8USER", JdeDataType.String, 20),
        new JdeField("T8PID", "T8PID", JdeDataType.String, 20),
        new JdeField("T8JOBN", "T8JOBN", JdeDataType.String, 20),
        new JdeField("T8UPMJ", "T8UPMJ", JdeDataType.Numeric),
        new JdeField("T8TDAY", "T8TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F410014D_0", "Primary Key on T8TMPL, T8MCU, T8LNGP", new[] { "T8TMPL", "T8MCU", "T8LNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
