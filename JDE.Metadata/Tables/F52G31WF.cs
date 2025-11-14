using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G31WF - .
/// </summary>
public class F52G31WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBJOBS.
        /// </summary>
        public const string RBJOBS = "RBJOBS";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBLT.
        /// </summary>
        public const string RBLT = "RBLT";

        /// <summary>
        /// RBSEGMID.
        /// </summary>
        public const string RBSEGMID = "RBSEGMID";

        /// <summary>
        /// RBBUCA.
        /// </summary>
        public const string RBBUCA = "RBBUCA";

        /// <summary>
        /// RBPOOLID.
        /// </summary>
        public const string RBPOOLID = "RBPOOLID";

        /// <summary>
        /// RBAA.
        /// </summary>
        public const string RBAA = "RBAA";

        /// <summary>
        /// RBAA3.
        /// </summary>
        public const string RBAA3 = "RBAA3";

        /// <summary>
        /// RBITOL.
        /// </summary>
        public const string RBITOL = "RBITOL";

        /// <summary>
        /// RBBTOL.
        /// </summary>
        public const string RBBTOL = "RBBTOL";

        /// <summary>
        /// RBAA1.
        /// </summary>
        public const string RBAA1 = "RBAA1";

        /// <summary>
        /// RBAA2.
        /// </summary>
        public const string RBAA2 = "RBAA2";

        /// <summary>
        /// RBITXA.
        /// </summary>
        public const string RBITXA = "RBITXA";

        /// <summary>
        /// RBITAM.
        /// </summary>
        public const string RBITAM = "RBITAM";

        /// <summary>
        /// RBDL01.
        /// </summary>
        public const string RBDL01 = "RBDL01";

        /// <summary>
        /// RBSEQ.
        /// </summary>
        public const string RBSEQ = "RBSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F52G31WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBJOBS", "RBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20, true, true),
        new JdeField("RBLT", "RBLT", JdeDataType.String, 4, true, true),
        new JdeField("RBSEGMID", "RBSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("RBBUCA", "RBBUCA", JdeDataType.String, 10),
        new JdeField("RBPOOLID", "RBPOOLID", JdeDataType.String, 8, true, true),
        new JdeField("RBAA", "RBAA", JdeDataType.Numeric),
        new JdeField("RBAA3", "RBAA3", JdeDataType.Numeric),
        new JdeField("RBITOL", "RBITOL", JdeDataType.Numeric),
        new JdeField("RBBTOL", "RBBTOL", JdeDataType.Numeric),
        new JdeField("RBAA1", "RBAA1", JdeDataType.Numeric),
        new JdeField("RBAA2", "RBAA2", JdeDataType.Numeric),
        new JdeField("RBITXA", "RBITXA", JdeDataType.Numeric),
        new JdeField("RBITAM", "RBITAM", JdeDataType.Numeric),
        new JdeField("RBDL01", "RBDL01", JdeDataType.String, 60),
        new JdeField("RBSEQ", "RBSEQ", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G31WF_0", "Primary Key on RBJOBS, RBUSER, RBLT, RBSEGMID, RBSEQ, RBPOOLID", new[] { "RBJOBS", "RBUSER", "RBLT", "RBSEGMID", "RBSEQ", "RBPOOLID" }, isUnique: true, isPrimaryKey: true)
    };
}
