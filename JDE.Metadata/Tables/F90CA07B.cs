using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA07B - .
/// </summary>
public class F90CA07B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBCNPFID.
        /// </summary>
        public const string CBCNPFID = "CBCNPFID";

        /// <summary>
        /// CBANSWID.
        /// </summary>
        public const string CBANSWID = "CBANSWID";

        /// <summary>
        /// CBPSAN8.
        /// </summary>
        public const string CBPSAN8 = "CBPSAN8";

        /// <summary>
        /// CBCNLNID.
        /// </summary>
        public const string CBCNLNID = "CBCNLNID";

        /// <summary>
        /// CBCPCODE.
        /// </summary>
        public const string CBCPCODE = "CBCPCODE";

        /// <summary>
        /// CBTXTANS.
        /// </summary>
        public const string CBTXTANS = "CBTXTANS";

        /// <summary>
        /// CBEXVAR0.
        /// </summary>
        public const string CBEXVAR0 = "CBEXVAR0";

        /// <summary>
        /// CBEXVAR1.
        /// </summary>
        public const string CBEXVAR1 = "CBEXVAR1";

        /// <summary>
        /// CBEXVAR4.
        /// </summary>
        public const string CBEXVAR4 = "CBEXVAR4";

        /// <summary>
        /// CBEXVAR5.
        /// </summary>
        public const string CBEXVAR5 = "CBEXVAR5";

        /// <summary>
        /// CBEXVAR6.
        /// </summary>
        public const string CBEXVAR6 = "CBEXVAR6";

        /// <summary>
        /// CBEXVAR7.
        /// </summary>
        public const string CBEXVAR7 = "CBEXVAR7";

        /// <summary>
        /// CBEXVAR12.
        /// </summary>
        public const string CBEXVAR12 = "CBEXVAR12";

        /// <summary>
        /// CBEXVAR13.
        /// </summary>
        public const string CBEXVAR13 = "CBEXVAR13";

        /// <summary>
        /// CBEXNM0.
        /// </summary>
        public const string CBEXNM0 = "CBEXNM0";

        /// <summary>
        /// CBEXNM1.
        /// </summary>
        public const string CBEXNM1 = "CBEXNM1";

        /// <summary>
        /// CBEXNM2.
        /// </summary>
        public const string CBEXNM2 = "CBEXNM2";

        /// <summary>
        /// CBEXNMP0.
        /// </summary>
        public const string CBEXNMP0 = "CBEXNMP0";

        /// <summary>
        /// CBEXNMP1.
        /// </summary>
        public const string CBEXNMP1 = "CBEXNMP1";

        /// <summary>
        /// CBEXNMP2.
        /// </summary>
        public const string CBEXNMP2 = "CBEXNMP2";

        /// <summary>
        /// CBEXDT0.
        /// </summary>
        public const string CBEXDT0 = "CBEXDT0";

        /// <summary>
        /// CBEXDT1.
        /// </summary>
        public const string CBEXDT1 = "CBEXDT1";

        /// <summary>
        /// CBEXDT2.
        /// </summary>
        public const string CBEXDT2 = "CBEXDT2";

        /// <summary>
        /// CBSTSUDT.
        /// </summary>
        public const string CBSTSUDT = "CBSTSUDT";

        /// <summary>
        /// CBACTIND.
        /// </summary>
        public const string CBACTIND = "CBACTIND";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBVID.
        /// </summary>
        public const string CBVID = "CBVID";

        /// <summary>
        /// CBMKEY.
        /// </summary>
        public const string CBMKEY = "CBMKEY";

        /// <summary>
        /// CBUDTTM.
        /// </summary>
        public const string CBUDTTM = "CBUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA07B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBCNPFID", "CBCNPFID", JdeDataType.Numeric, null, true, true),
        new JdeField("CBANSWID", "CBANSWID", JdeDataType.Numeric),
        new JdeField("CBPSAN8", "CBPSAN8", JdeDataType.Numeric),
        new JdeField("CBCNLNID", "CBCNLNID", JdeDataType.Numeric),
        new JdeField("CBCPCODE", "CBCPCODE", JdeDataType.String, 30),
        new JdeField("CBTXTANS", "CBTXTANS", JdeDataType.String, 200),
        new JdeField("CBEXVAR0", "CBEXVAR0", JdeDataType.String, 510),
        new JdeField("CBEXVAR1", "CBEXVAR1", JdeDataType.String, 510),
        new JdeField("CBEXVAR4", "CBEXVAR4", JdeDataType.String, 100),
        new JdeField("CBEXVAR5", "CBEXVAR5", JdeDataType.String, 100),
        new JdeField("CBEXVAR6", "CBEXVAR6", JdeDataType.String, 100),
        new JdeField("CBEXVAR7", "CBEXVAR7", JdeDataType.String, 100),
        new JdeField("CBEXVAR12", "CBEXVAR12", JdeDataType.String, 50),
        new JdeField("CBEXVAR13", "CBEXVAR13", JdeDataType.String, 50),
        new JdeField("CBEXNM0", "CBEXNM0", JdeDataType.Numeric),
        new JdeField("CBEXNM1", "CBEXNM1", JdeDataType.Numeric),
        new JdeField("CBEXNM2", "CBEXNM2", JdeDataType.Numeric),
        new JdeField("CBEXNMP0", "CBEXNMP0", JdeDataType.Numeric),
        new JdeField("CBEXNMP1", "CBEXNMP1", JdeDataType.Numeric),
        new JdeField("CBEXNMP2", "CBEXNMP2", JdeDataType.Numeric),
        new JdeField("CBEXDT0", "CBEXDT0", JdeDataType.Date),
        new JdeField("CBEXDT1", "CBEXDT1", JdeDataType.Date),
        new JdeField("CBEXDT2", "CBEXDT2", JdeDataType.Date),
        new JdeField("CBSTSUDT", "CBSTSUDT", JdeDataType.Date),
        new JdeField("CBACTIND", "CBACTIND", JdeDataType.String, 2),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBVID", "CBVID", JdeDataType.String, 20),
        new JdeField("CBMKEY", "CBMKEY", JdeDataType.String, 30),
        new JdeField("CBUDTTM", "CBUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA07B_0", "Primary Key on CBCNPFID", new[] { "CBCNPFID" }, isUnique: true, isPrimaryKey: true)
    };
}
