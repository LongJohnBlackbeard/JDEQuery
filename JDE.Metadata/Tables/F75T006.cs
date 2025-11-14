using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T006 - .
/// </summary>
public class F75T006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPT75GUIP.
        /// </summary>
        public const string GPT75GUIP = "GPT75GUIP";

        /// <summary>
        /// GP75TGFC.
        /// </summary>
        public const string GP75TGFC = "GP75TGFC";

        /// <summary>
        /// GP75TYMH.
        /// </summary>
        public const string GP75TYMH = "GP75TYMH";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPTDAY.
        /// </summary>
        public const string GPTDAY = "GPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPT75GUIP", "GPT75GUIP", JdeDataType.String, 8, true, true),
        new JdeField("GP75TGFC", "GP75TGFC", JdeDataType.String, 4, true, true),
        new JdeField("GP75TYMH", "GP75TYMH", JdeDataType.Numeric, null, true, true),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPTDAY", "GPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T006_0", "Primary Key on GP75TGFC, GP75TYMH, GPT75GUIP", new[] { "GP75TGFC", "GP75TYMH", "GPT75GUIP" }, isUnique: true, isPrimaryKey: true)
    };
}
