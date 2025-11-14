using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1208 - .
/// </summary>
public class F1208 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPADSN.
        /// </summary>
        public const string FPADSN = "FPADSN";

        /// <summary>
        /// FPLT.
        /// </summary>
        public const string FPLT = "FPLT";

        /// <summary>
        /// FPDL01.
        /// </summary>
        public const string FPDL01 = "FPDL01";

        /// <summary>
        /// FPUM.
        /// </summary>
        public const string FPUM = "FPUM";

        /// <summary>
        /// FPCMP.
        /// </summary>
        public const string FPCMP = "FPCMP";

        /// <summary>
        /// FPUPP.
        /// </summary>
        public const string FPUPP = "FPUPP";

        /// <summary>
        /// FPUPY.
        /// </summary>
        public const string FPUPY = "FPUPY";

        /// <summary>
        /// FPTOU.
        /// </summary>
        public const string FPTOU = "FPTOU";

        /// <summary>
        /// FPPRV.
        /// </summary>
        public const string FPPRV = "FPPRV";

        /// <summary>
        /// FPCRV.
        /// </summary>
        public const string FPCRV = "FPCRV";

        /// <summary>
        /// FPLCT.
        /// </summary>
        public const string FPLCT = "FPLCT";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPJOBN.
        /// </summary>
        public const string FPJOBN = "FPJOBN";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1208";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPADSN", "FPADSN", JdeDataType.String, 24, true, true),
        new JdeField("FPLT", "FPLT", JdeDataType.String, 4, true, true),
        new JdeField("FPDL01", "FPDL01", JdeDataType.String, 60),
        new JdeField("FPUM", "FPUM", JdeDataType.String, 4),
        new JdeField("FPCMP", "FPCMP", JdeDataType.Numeric),
        new JdeField("FPUPP", "FPUPP", JdeDataType.Numeric),
        new JdeField("FPUPY", "FPUPY", JdeDataType.Numeric),
        new JdeField("FPTOU", "FPTOU", JdeDataType.Numeric),
        new JdeField("FPPRV", "FPPRV", JdeDataType.Numeric),
        new JdeField("FPCRV", "FPCRV", JdeDataType.Numeric),
        new JdeField("FPLCT", "FPLCT", JdeDataType.Numeric),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPJOBN", "FPJOBN", JdeDataType.String, 20),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1208_0", "Primary Key on FPADSN, FPLT", new[] { "FPADSN", "FPLT" }, isUnique: true, isPrimaryKey: true)
    };
}
