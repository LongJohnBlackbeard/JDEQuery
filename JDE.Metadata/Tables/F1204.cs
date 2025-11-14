using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1204 - .
/// </summary>
public class F1204 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FMNUMB.
        /// </summary>
        public const string FMNUMB = "FMNUMB";

        /// <summary>
        /// FMAL.
        /// </summary>
        public const string FMAL = "FMAL";

        /// <summary>
        /// FMLOC.
        /// </summary>
        public const string FMLOC = "FMLOC";

        /// <summary>
        /// FMEND.
        /// </summary>
        public const string FMEND = "FMEND";

        /// <summary>
        /// FMRMK.
        /// </summary>
        public const string FMRMK = "FMRMK";

        /// <summary>
        /// FMLCT.
        /// </summary>
        public const string FMLCT = "FMLCT";

        /// <summary>
        /// FMUSER.
        /// </summary>
        public const string FMUSER = "FMUSER";

        /// <summary>
        /// FMPID.
        /// </summary>
        public const string FMPID = "FMPID";

        /// <summary>
        /// FMJOBN.
        /// </summary>
        public const string FMJOBN = "FMJOBN";

        /// <summary>
        /// FMTRNN.
        /// </summary>
        public const string FMTRNN = "FMTRNN";

        /// <summary>
        /// FMERC.
        /// </summary>
        public const string FMERC = "FMERC";

        /// <summary>
        /// FMQTY.
        /// </summary>
        public const string FMQTY = "FMQTY";

        /// <summary>
        /// FMEQST.
        /// </summary>
        public const string FMEQST = "FMEQST";

        /// <summary>
        /// FMNNBR.
        /// </summary>
        public const string FMNNBR = "FMNNBR";

        /// <summary>
        /// FMMCU.
        /// </summary>
        public const string FMMCU = "FMMCU";

        /// <summary>
        /// FMEFTB.
        /// </summary>
        public const string FMEFTB = "FMEFTB";

        /// <summary>
        /// FMSUB.
        /// </summary>
        public const string FMSUB = "FMSUB";

        /// <summary>
        /// FMOBJ.
        /// </summary>
        public const string FMOBJ = "FMOBJ";

        /// <summary>
        /// FMDDTS.
        /// </summary>
        public const string FMDDTS = "FMDDTS";

        /// <summary>
        /// FMDTSO.
        /// </summary>
        public const string FMDTSO = "FMDTSO";

        /// <summary>
        /// FMMTRO.
        /// </summary>
        public const string FMMTRO = "FMMTRO";

        /// <summary>
        /// FMMTRC.
        /// </summary>
        public const string FMMTRC = "FMMTRC";

        /// <summary>
        /// FMRTTB.
        /// </summary>
        public const string FMRTTB = "FMRTTB";

        /// <summary>
        /// FMRTGR.
        /// </summary>
        public const string FMRTGR = "FMRTGR";

        /// <summary>
        /// FMAMTB.
        /// </summary>
        public const string FMAMTB = "FMAMTB";

        /// <summary>
        /// FMAISL.
        /// </summary>
        public const string FMAISL = "FMAISL";

        /// <summary>
        /// FMBIN.
        /// </summary>
        public const string FMBIN = "FMBIN";

        /// <summary>
        /// FMSBL.
        /// </summary>
        public const string FMSBL = "FMSBL";

        /// <summary>
        /// FMSBLT.
        /// </summary>
        public const string FMSBLT = "FMSBLT";

        /// <summary>
        /// FMROS.
        /// </summary>
        public const string FMROS = "FMROS";

        /// <summary>
        /// FMUPMT.
        /// </summary>
        public const string FMUPMT = "FMUPMT";

        /// <summary>
        /// FMAN8.
        /// </summary>
        public const string FMAN8 = "FMAN8";

        /// <summary>
        /// FMDOCO.
        /// </summary>
        public const string FMDOCO = "FMDOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F1204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FMNUMB", "FMNUMB", JdeDataType.Numeric),
        new JdeField("FMAL", "FMAL", JdeDataType.String, 2),
        new JdeField("FMLOC", "FMLOC", JdeDataType.String, 24),
        new JdeField("FMEND", "FMEND", JdeDataType.Numeric),
        new JdeField("FMRMK", "FMRMK", JdeDataType.String, 60),
        new JdeField("FMLCT", "FMLCT", JdeDataType.Numeric),
        new JdeField("FMUSER", "FMUSER", JdeDataType.String, 20),
        new JdeField("FMPID", "FMPID", JdeDataType.String, 20),
        new JdeField("FMJOBN", "FMJOBN", JdeDataType.String, 20),
        new JdeField("FMTRNN", "FMTRNN", JdeDataType.String, 24),
        new JdeField("FMERC", "FMERC", JdeDataType.String, 4),
        new JdeField("FMQTY", "FMQTY", JdeDataType.Numeric),
        new JdeField("FMEQST", "FMEQST", JdeDataType.String, 4),
        new JdeField("FMNNBR", "FMNNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("FMMCU", "FMMCU", JdeDataType.String, 24),
        new JdeField("FMEFTB", "FMEFTB", JdeDataType.Numeric),
        new JdeField("FMSUB", "FMSUB", JdeDataType.String, 16),
        new JdeField("FMOBJ", "FMOBJ", JdeDataType.String, 12),
        new JdeField("FMDDTS", "FMDDTS", JdeDataType.Numeric),
        new JdeField("FMDTSO", "FMDTSO", JdeDataType.Numeric),
        new JdeField("FMMTRO", "FMMTRO", JdeDataType.Numeric),
        new JdeField("FMMTRC", "FMMTRC", JdeDataType.Numeric),
        new JdeField("FMRTTB", "FMRTTB", JdeDataType.String, 6),
        new JdeField("FMRTGR", "FMRTGR", JdeDataType.String, 6),
        new JdeField("FMAMTB", "FMAMTB", JdeDataType.Numeric),
        new JdeField("FMAISL", "FMAISL", JdeDataType.String, 16),
        new JdeField("FMBIN", "FMBIN", JdeDataType.String, 16),
        new JdeField("FMSBL", "FMSBL", JdeDataType.String, 16),
        new JdeField("FMSBLT", "FMSBLT", JdeDataType.String, 2),
        new JdeField("FMROS", "FMROS", JdeDataType.String, 2),
        new JdeField("FMUPMT", "FMUPMT", JdeDataType.Numeric),
        new JdeField("FMAN8", "FMAN8", JdeDataType.Numeric),
        new JdeField("FMDOCO", "FMDOCO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1204_0", "Primary Key on FMNNBR", new[] { "FMNNBR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1204_10", "Index on FMTRNN, FMNNBR", new[] { "FMTRNN", "FMNNBR" }),
        new JdeIndex("F1204_11", "Index on FMNUMB, FMAL, SYS_NC00034$, SYS_NC00037$", new[] { "FMNUMB", "FMAL", "SYS_NC00034$", "SYS_NC00037$" }),
        new JdeIndex("F1204_2", "Index on FMNUMB, FMAL, SYS_NC00034$", new[] { "FMNUMB", "FMAL", "SYS_NC00034$" }),
        new JdeIndex("F1204_3", "Index on FMLOC, FMNUMB, FMAL, SYS_NC00034$", new[] { "FMLOC", "FMNUMB", "FMAL", "SYS_NC00034$" }),
        new JdeIndex("F1204_4", "Index on FMLOC, FMNUMB, FMAL", new[] { "FMLOC", "FMNUMB", "FMAL" }),
        new JdeIndex("F1204_5", "Index on FMNUMB, FMEFTB", new[] { "FMNUMB", "FMEFTB" }),
        new JdeIndex("F1204_6", "Index on SYS_NC00034$, SYS_NC00035$, SYS_NC00036$", new[] { "SYS_NC00034$", "SYS_NC00035$", "SYS_NC00036$" })
    };
}
