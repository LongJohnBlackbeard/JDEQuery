using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4016 - .
/// </summary>
public class F4016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TUINMG.
        /// </summary>
        public const string TUINMG = "TUINMG";

        /// <summary>
        /// TUITM.
        /// </summary>
        public const string TUITM = "TUITM";

        /// <summary>
        /// TUEFTJ.
        /// </summary>
        public const string TUEFTJ = "TUEFTJ";

        /// <summary>
        /// TUEXDJ.
        /// </summary>
        public const string TUEXDJ = "TUEXDJ";

        /// <summary>
        /// TUPNTC.
        /// </summary>
        public const string TUPNTC = "TUPNTC";

        /// <summary>
        /// TULNGP.
        /// </summary>
        public const string TULNGP = "TULNGP";

        /// <summary>
        /// TUUSER.
        /// </summary>
        public const string TUUSER = "TUUSER";

        /// <summary>
        /// TUJOBN.
        /// </summary>
        public const string TUJOBN = "TUJOBN";

        /// <summary>
        /// TUPID.
        /// </summary>
        public const string TUPID = "TUPID";

        /// <summary>
        /// TUUPMJ.
        /// </summary>
        public const string TUUPMJ = "TUUPMJ";

        /// <summary>
        /// TUTDAY.
        /// </summary>
        public const string TUTDAY = "TUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TUINMG", "TUINMG", JdeDataType.String, 20, true, true),
        new JdeField("TUITM", "TUITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TUEFTJ", "TUEFTJ", JdeDataType.Numeric),
        new JdeField("TUEXDJ", "TUEXDJ", JdeDataType.Numeric),
        new JdeField("TUPNTC", "TUPNTC", JdeDataType.String, 2),
        new JdeField("TULNGP", "TULNGP", JdeDataType.String, 4, true, true),
        new JdeField("TUUSER", "TUUSER", JdeDataType.String, 20),
        new JdeField("TUJOBN", "TUJOBN", JdeDataType.String, 20),
        new JdeField("TUPID", "TUPID", JdeDataType.String, 20),
        new JdeField("TUUPMJ", "TUUPMJ", JdeDataType.Numeric),
        new JdeField("TUTDAY", "TUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4016_0", "Primary Key on TULNGP, TUINMG, TUITM", new[] { "TULNGP", "TUINMG", "TUITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4016_2", "Index on TULNGP, TUITM", new[] { "TULNGP", "TUITM" }),
        new JdeIndex("F4016_3", "Index on TUINMG, TUITM, TULNGP", new[] { "TUINMG", "TUITM", "TULNGP" })
    };
}
