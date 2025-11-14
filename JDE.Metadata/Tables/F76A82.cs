using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A82 - .
/// </summary>
public class F76A82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C6PYID.
        /// </summary>
        public const string C6PYID = "C6PYID";

        /// <summary>
        /// C6LNID.
        /// </summary>
        public const string C6LNID = "C6LNID";

        /// <summary>
        /// C6DCT.
        /// </summary>
        public const string C6DCT = "C6DCT";

        /// <summary>
        /// C6AN8.
        /// </summary>
        public const string C6AN8 = "C6AN8";

        /// <summary>
        /// C6AG.
        /// </summary>
        public const string C6AG = "C6AG";

        /// <summary>
        /// C6ACR.
        /// </summary>
        public const string C6ACR = "C6ACR";

        /// <summary>
        /// C6ATXA.
        /// </summary>
        public const string C6ATXA = "C6ATXA";

        /// <summary>
        /// C6A001.
        /// </summary>
        public const string C6A001 = "C6A001";

        /// <summary>
        /// C6A002.
        /// </summary>
        public const string C6A002 = "C6A002";

        /// <summary>
        /// C6A003.
        /// </summary>
        public const string C6A003 = "C6A003";

        /// <summary>
        /// C6A004.
        /// </summary>
        public const string C6A004 = "C6A004";

        /// <summary>
        /// C6A005.
        /// </summary>
        public const string C6A005 = "C6A005";

        /// <summary>
        /// C6A006.
        /// </summary>
        public const string C6A006 = "C6A006";

        /// <summary>
        /// C6A007.
        /// </summary>
        public const string C6A007 = "C6A007";

        /// <summary>
        /// C6A008.
        /// </summary>
        public const string C6A008 = "C6A008";

        /// <summary>
        /// C6A009.
        /// </summary>
        public const string C6A009 = "C6A009";

        /// <summary>
        /// C6A010.
        /// </summary>
        public const string C6A010 = "C6A010";

        /// <summary>
        /// C6A011.
        /// </summary>
        public const string C6A011 = "C6A011";

        /// <summary>
        /// C6DL01.
        /// </summary>
        public const string C6DL01 = "C6DL01";

        /// <summary>
        /// C6URDT.
        /// </summary>
        public const string C6URDT = "C6URDT";

        /// <summary>
        /// C6YR.
        /// </summary>
        public const string C6YR = "C6YR";

        /// <summary>
        /// C6MT.
        /// </summary>
        public const string C6MT = "C6MT";

        /// <summary>
        /// C6CO.
        /// </summary>
        public const string C6CO = "C6CO";

        /// <summary>
        /// C6TAX.
        /// </summary>
        public const string C6TAX = "C6TAX";

        /// <summary>
        /// C6ALPH.
        /// </summary>
        public const string C6ALPH = "C6ALPH";

        /// <summary>
        /// C6ADD1.
        /// </summary>
        public const string C6ADD1 = "C6ADD1";

        /// <summary>
        /// C6ADD2.
        /// </summary>
        public const string C6ADD2 = "C6ADD2";

        /// <summary>
        /// C6ADDZ.
        /// </summary>
        public const string C6ADDZ = "C6ADDZ";

        /// <summary>
        /// C6CTY1.
        /// </summary>
        public const string C6CTY1 = "C6CTY1";

        /// <summary>
        /// C6ADDS.
        /// </summary>
        public const string C6ADDS = "C6ADDS";

        /// <summary>
        /// C6CTR.
        /// </summary>
        public const string C6CTR = "C6CTR";

        /// <summary>
        /// C6PYIN.
        /// </summary>
        public const string C6PYIN = "C6PYIN";

        /// <summary>
        /// C6DL02.
        /// </summary>
        public const string C6DL02 = "C6DL02";

        /// <summary>
        /// C6ODCT.
        /// </summary>
        public const string C6ODCT = "C6ODCT";

        /// <summary>
        /// C6ODOC.
        /// </summary>
        public const string C6ODOC = "C6ODOC";

        /// <summary>
        /// C6OKCO.
        /// </summary>
        public const string C6OKCO = "C6OKCO";

        /// <summary>
        /// C6VOD.
        /// </summary>
        public const string C6VOD = "C6VOD";

        /// <summary>
        /// C6PID.
        /// </summary>
        public const string C6PID = "C6PID";

        /// <summary>
        /// C6JOBN.
        /// </summary>
        public const string C6JOBN = "C6JOBN";

        /// <summary>
        /// C6USER.
        /// </summary>
        public const string C6USER = "C6USER";

        /// <summary>
        /// C6UPMJ.
        /// </summary>
        public const string C6UPMJ = "C6UPMJ";

        /// <summary>
        /// C6UPMT.
        /// </summary>
        public const string C6UPMT = "C6UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C6PYID", "C6PYID", JdeDataType.Numeric, null, true, true),
        new JdeField("C6LNID", "C6LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("C6DCT", "C6DCT", JdeDataType.String, 4),
        new JdeField("C6AN8", "C6AN8", JdeDataType.Numeric),
        new JdeField("C6AG", "C6AG", JdeDataType.Numeric),
        new JdeField("C6ACR", "C6ACR", JdeDataType.Numeric),
        new JdeField("C6ATXA", "C6ATXA", JdeDataType.Numeric),
        new JdeField("C6A001", "C6A001", JdeDataType.String, 6),
        new JdeField("C6A002", "C6A002", JdeDataType.String, 6),
        new JdeField("C6A003", "C6A003", JdeDataType.String, 6),
        new JdeField("C6A004", "C6A004", JdeDataType.String, 6),
        new JdeField("C6A005", "C6A005", JdeDataType.String, 6),
        new JdeField("C6A006", "C6A006", JdeDataType.String, 6),
        new JdeField("C6A007", "C6A007", JdeDataType.String, 6),
        new JdeField("C6A008", "C6A008", JdeDataType.String, 6),
        new JdeField("C6A009", "C6A009", JdeDataType.String, 6),
        new JdeField("C6A010", "C6A010", JdeDataType.String, 6),
        new JdeField("C6A011", "C6A011", JdeDataType.String, 6),
        new JdeField("C6DL01", "C6DL01", JdeDataType.String, 60),
        new JdeField("C6URDT", "C6URDT", JdeDataType.Numeric),
        new JdeField("C6YR", "C6YR", JdeDataType.Numeric),
        new JdeField("C6MT", "C6MT", JdeDataType.Numeric),
        new JdeField("C6CO", "C6CO", JdeDataType.String, 10),
        new JdeField("C6TAX", "C6TAX", JdeDataType.String, 40),
        new JdeField("C6ALPH", "C6ALPH", JdeDataType.String, 80),
        new JdeField("C6ADD1", "C6ADD1", JdeDataType.String, 80),
        new JdeField("C6ADD2", "C6ADD2", JdeDataType.String, 80),
        new JdeField("C6ADDZ", "C6ADDZ", JdeDataType.String, 24),
        new JdeField("C6CTY1", "C6CTY1", JdeDataType.String, 50),
        new JdeField("C6ADDS", "C6ADDS", JdeDataType.String, 6),
        new JdeField("C6CTR", "C6CTR", JdeDataType.String, 6),
        new JdeField("C6PYIN", "C6PYIN", JdeDataType.String, 2),
        new JdeField("C6DL02", "C6DL02", JdeDataType.String, 60),
        new JdeField("C6ODCT", "C6ODCT", JdeDataType.String, 4),
        new JdeField("C6ODOC", "C6ODOC", JdeDataType.Numeric),
        new JdeField("C6OKCO", "C6OKCO", JdeDataType.String, 10),
        new JdeField("C6VOD", "C6VOD", JdeDataType.String, 2),
        new JdeField("C6PID", "C6PID", JdeDataType.String, 20),
        new JdeField("C6JOBN", "C6JOBN", JdeDataType.String, 20),
        new JdeField("C6USER", "C6USER", JdeDataType.String, 20),
        new JdeField("C6UPMJ", "C6UPMJ", JdeDataType.Numeric),
        new JdeField("C6UPMT", "C6UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A82_0", "Primary Key on C6PYID, C6LNID", new[] { "C6PYID", "C6LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
