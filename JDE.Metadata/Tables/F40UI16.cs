using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI16 - .
/// </summary>
public class F40UI16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSCTID.
        /// </summary>
        public const string DSCTID = "DSCTID";

        /// <summary>
        /// DSJOBS.
        /// </summary>
        public const string DSJOBS = "DSJOBS";

        /// <summary>
        /// DSDOCO.
        /// </summary>
        public const string DSDOCO = "DSDOCO";

        /// <summary>
        /// DSDCTO.
        /// </summary>
        public const string DSDCTO = "DSDCTO";

        /// <summary>
        /// DSKCOO.
        /// </summary>
        public const string DSKCOO = "DSKCOO";

        /// <summary>
        /// DSTYC.
        /// </summary>
        public const string DSTYC = "DSTYC";

        /// <summary>
        /// DSSEQ.
        /// </summary>
        public const string DSSEQ = "DSSEQ";

        /// <summary>
        /// DSINMG.
        /// </summary>
        public const string DSINMG = "DSINMG";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSCTID", "DSCTID", JdeDataType.String, 30, true, true),
        new JdeField("DSJOBS", "DSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DSDOCO", "DSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DSDCTO", "DSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DSKCOO", "DSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DSTYC", "DSTYC", JdeDataType.String, 2, true, true),
        new JdeField("DSSEQ", "DSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DSINMG", "DSINMG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI16_0", "Primary Key on DSCTID, DSJOBS, DSDOCO, DSDCTO, DSKCOO, DSTYC, DSSEQ", new[] { "DSCTID", "DSJOBS", "DSDOCO", "DSDCTO", "DSKCOO", "DSTYC", "DSSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40UI16_2", "Index on DSDOCO, DSDCTO, DSKCOO", new[] { "DSDOCO", "DSDCTO", "DSKCOO" })
    };
}
