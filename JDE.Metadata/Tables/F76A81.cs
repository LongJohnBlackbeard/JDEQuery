using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A81 - .
/// </summary>
public class F76A81 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C5HDC.
        /// </summary>
        public const string C5HDC = "C5HDC";

        /// <summary>
        /// C5CKC.
        /// </summary>
        public const string C5CKC = "C5CKC";

        /// <summary>
        /// C5LNID.
        /// </summary>
        public const string C5LNID = "C5LNID";

        /// <summary>
        /// C5DCT.
        /// </summary>
        public const string C5DCT = "C5DCT";

        /// <summary>
        /// C5AN8.
        /// </summary>
        public const string C5AN8 = "C5AN8";

        /// <summary>
        /// C5AG.
        /// </summary>
        public const string C5AG = "C5AG";

        /// <summary>
        /// C5ACR.
        /// </summary>
        public const string C5ACR = "C5ACR";

        /// <summary>
        /// C5ATXA.
        /// </summary>
        public const string C5ATXA = "C5ATXA";

        /// <summary>
        /// C5A001.
        /// </summary>
        public const string C5A001 = "C5A001";

        /// <summary>
        /// C5A002.
        /// </summary>
        public const string C5A002 = "C5A002";

        /// <summary>
        /// C5A003.
        /// </summary>
        public const string C5A003 = "C5A003";

        /// <summary>
        /// C5A004.
        /// </summary>
        public const string C5A004 = "C5A004";

        /// <summary>
        /// C5A005.
        /// </summary>
        public const string C5A005 = "C5A005";

        /// <summary>
        /// C5A006.
        /// </summary>
        public const string C5A006 = "C5A006";

        /// <summary>
        /// C5A007.
        /// </summary>
        public const string C5A007 = "C5A007";

        /// <summary>
        /// C5A008.
        /// </summary>
        public const string C5A008 = "C5A008";

        /// <summary>
        /// C5A009.
        /// </summary>
        public const string C5A009 = "C5A009";

        /// <summary>
        /// C5A010.
        /// </summary>
        public const string C5A010 = "C5A010";

        /// <summary>
        /// C5A011.
        /// </summary>
        public const string C5A011 = "C5A011";

        /// <summary>
        /// C5DMTJ.
        /// </summary>
        public const string C5DMTJ = "C5DMTJ";

        /// <summary>
        /// C5CO.
        /// </summary>
        public const string C5CO = "C5CO";

        /// <summary>
        /// C5PYIN.
        /// </summary>
        public const string C5PYIN = "C5PYIN";

        /// <summary>
        /// C5ODCT.
        /// </summary>
        public const string C5ODCT = "C5ODCT";

        /// <summary>
        /// C5ODOC.
        /// </summary>
        public const string C5ODOC = "C5ODOC";

        /// <summary>
        /// C5OKCO.
        /// </summary>
        public const string C5OKCO = "C5OKCO";

        /// <summary>
        /// C5PID.
        /// </summary>
        public const string C5PID = "C5PID";

        /// <summary>
        /// C5JOBN.
        /// </summary>
        public const string C5JOBN = "C5JOBN";

        /// <summary>
        /// C5USER.
        /// </summary>
        public const string C5USER = "C5USER";

        /// <summary>
        /// C5UPMJ.
        /// </summary>
        public const string C5UPMJ = "C5UPMJ";

        /// <summary>
        /// C5UPMT.
        /// </summary>
        public const string C5UPMT = "C5UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A81";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C5HDC", "C5HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("C5CKC", "C5CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("C5LNID", "C5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("C5DCT", "C5DCT", JdeDataType.String, 4),
        new JdeField("C5AN8", "C5AN8", JdeDataType.Numeric),
        new JdeField("C5AG", "C5AG", JdeDataType.Numeric),
        new JdeField("C5ACR", "C5ACR", JdeDataType.Numeric),
        new JdeField("C5ATXA", "C5ATXA", JdeDataType.Numeric),
        new JdeField("C5A001", "C5A001", JdeDataType.String, 6),
        new JdeField("C5A002", "C5A002", JdeDataType.String, 6),
        new JdeField("C5A003", "C5A003", JdeDataType.String, 6),
        new JdeField("C5A004", "C5A004", JdeDataType.String, 6),
        new JdeField("C5A005", "C5A005", JdeDataType.String, 6),
        new JdeField("C5A006", "C5A006", JdeDataType.String, 6),
        new JdeField("C5A007", "C5A007", JdeDataType.String, 6),
        new JdeField("C5A008", "C5A008", JdeDataType.String, 6),
        new JdeField("C5A009", "C5A009", JdeDataType.String, 6),
        new JdeField("C5A010", "C5A010", JdeDataType.String, 6),
        new JdeField("C5A011", "C5A011", JdeDataType.String, 6),
        new JdeField("C5DMTJ", "C5DMTJ", JdeDataType.Numeric),
        new JdeField("C5CO", "C5CO", JdeDataType.String, 10),
        new JdeField("C5PYIN", "C5PYIN", JdeDataType.String, 2),
        new JdeField("C5ODCT", "C5ODCT", JdeDataType.String, 4),
        new JdeField("C5ODOC", "C5ODOC", JdeDataType.Numeric),
        new JdeField("C5OKCO", "C5OKCO", JdeDataType.String, 10),
        new JdeField("C5PID", "C5PID", JdeDataType.String, 20),
        new JdeField("C5JOBN", "C5JOBN", JdeDataType.String, 20),
        new JdeField("C5USER", "C5USER", JdeDataType.String, 20),
        new JdeField("C5UPMJ", "C5UPMJ", JdeDataType.Numeric),
        new JdeField("C5UPMT", "C5UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A81_0", "Primary Key on C5HDC, C5CKC, C5LNID", new[] { "C5HDC", "C5CKC", "C5LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
