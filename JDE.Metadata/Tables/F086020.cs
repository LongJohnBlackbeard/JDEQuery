using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086020 - .
/// </summary>
public class F086020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTUTID.
        /// </summary>
        public const string VTUTID = "VTUTID";

        /// <summary>
        /// VTSEQ.
        /// </summary>
        public const string VTSEQ = "VTSEQ";

        /// <summary>
        /// VTJOBS.
        /// </summary>
        public const string VTJOBS = "VTJOBS";

        /// <summary>
        /// VTESTB.
        /// </summary>
        public const string VTESTB = "VTESTB";

        /// <summary>
        /// VTDL01.
        /// </summary>
        public const string VTDL01 = "VTDL01";

        /// <summary>
        /// VTCALYEAR.
        /// </summary>
        public const string VTCALYEAR = "VTCALYEAR";

        /// <summary>
        /// VTCDV.
        /// </summary>
        public const string VTCDV = "VTCDV";

        /// <summary>
        /// VTFDVL.
        /// </summary>
        public const string VTFDVL = "VTFDVL";

        /// <summary>
        /// VTD200.
        /// </summary>
        public const string VTD200 = "VTD200";

        /// <summary>
        /// VTJOBN.
        /// </summary>
        public const string VTJOBN = "VTJOBN";

        /// <summary>
        /// VTUPMJ.
        /// </summary>
        public const string VTUPMJ = "VTUPMJ";

        /// <summary>
        /// VTUPMT.
        /// </summary>
        public const string VTUPMT = "VTUPMT";

        /// <summary>
        /// VTUSER.
        /// </summary>
        public const string VTUSER = "VTUSER";

        /// <summary>
        /// VTPID.
        /// </summary>
        public const string VTPID = "VTPID";
    }

    /// <inheritdoc />
    public override string TableName => "F086020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTUTID", "VTUTID", JdeDataType.String, 102, true, true),
        new JdeField("VTSEQ", "VTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("VTJOBS", "VTJOBS", JdeDataType.Numeric),
        new JdeField("VTESTB", "VTESTB", JdeDataType.Numeric),
        new JdeField("VTDL01", "VTDL01", JdeDataType.String, 60),
        new JdeField("VTCALYEAR", "VTCALYEAR", JdeDataType.Numeric),
        new JdeField("VTCDV", "VTCDV", JdeDataType.String, 80),
        new JdeField("VTFDVL", "VTFDVL", JdeDataType.String, 80),
        new JdeField("VTD200", "VTD200", JdeDataType.String, 400),
        new JdeField("VTJOBN", "VTJOBN", JdeDataType.String, 20),
        new JdeField("VTUPMJ", "VTUPMJ", JdeDataType.Numeric),
        new JdeField("VTUPMT", "VTUPMT", JdeDataType.Numeric),
        new JdeField("VTUSER", "VTUSER", JdeDataType.String, 20),
        new JdeField("VTPID", "VTPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086020_0", "Primary Key on VTUTID, VTSEQ", new[] { "VTUTID", "VTSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
