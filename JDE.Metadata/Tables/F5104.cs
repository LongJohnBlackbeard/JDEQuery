using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5104 - .
/// </summary>
public class F5104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSRPOITM.
        /// </summary>
        public const string MSRPOITM = "MSRPOITM";

        /// <summary>
        /// MSKYTY.
        /// </summary>
        public const string MSKYTY = "MSKYTY";

        /// <summary>
        /// MSKCV.
        /// </summary>
        public const string MSKCV = "MSKCV";

        /// <summary>
        /// MSKEYV.
        /// </summary>
        public const string MSKEYV = "MSKEYV";

        /// <summary>
        /// MSLNID.
        /// </summary>
        public const string MSLNID = "MSLNID";

        /// <summary>
        /// MSFCOT.
        /// </summary>
        public const string MSFCOT = "MSFCOT";

        /// <summary>
        /// MSFCOC.
        /// </summary>
        public const string MSFCOC = "MSFCOC";

        /// <summary>
        /// MSTCOT.
        /// </summary>
        public const string MSTCOT = "MSTCOT";

        /// <summary>
        /// MSTCOC.
        /// </summary>
        public const string MSTCOC = "MSTCOC";

        /// <summary>
        /// MSMCURN.
        /// </summary>
        public const string MSMCURN = "MSMCURN";

        /// <summary>
        /// MSOBJRN.
        /// </summary>
        public const string MSOBJRN = "MSOBJRN";

        /// <summary>
        /// MSSUBRN.
        /// </summary>
        public const string MSSUBRN = "MSSUBRN";

        /// <summary>
        /// MSDTEFCT.
        /// </summary>
        public const string MSDTEFCT = "MSDTEFCT";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MSUPMT.
        /// </summary>
        public const string MSUPMT = "MSUPMT";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F5104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSRPOITM", "MSRPOITM", JdeDataType.String, 6, true, true),
        new JdeField("MSKYTY", "MSKYTY", JdeDataType.String, 2, true, true),
        new JdeField("MSKCV", "MSKCV", JdeDataType.Numeric, null, true, true),
        new JdeField("MSKEYV", "MSKEYV", JdeDataType.String, 60, true, true),
        new JdeField("MSLNID", "MSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MSFCOT", "MSFCOT", JdeDataType.String, 12),
        new JdeField("MSFCOC", "MSFCOC", JdeDataType.String, 16),
        new JdeField("MSTCOT", "MSTCOT", JdeDataType.String, 12),
        new JdeField("MSTCOC", "MSTCOC", JdeDataType.String, 16),
        new JdeField("MSMCURN", "MSMCURN", JdeDataType.String, 24),
        new JdeField("MSOBJRN", "MSOBJRN", JdeDataType.String, 12),
        new JdeField("MSSUBRN", "MSSUBRN", JdeDataType.String, 16),
        new JdeField("MSDTEFCT", "MSDTEFCT", JdeDataType.Numeric, null, true, true),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MSUPMT", "MSUPMT", JdeDataType.Numeric),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5104_0", "Primary Key on MSRPOITM, MSLNID, MSKYTY, MSKCV, MSKEYV, MSDTEFCT", new[] { "MSRPOITM", "MSLNID", "MSKYTY", "MSKCV", "MSKEYV", "MSDTEFCT" }, isUnique: true, isPrimaryKey: true)
    };
}
