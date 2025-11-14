using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I862 - .
/// </summary>
public class F75I862 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDUKID.
        /// </summary>
        public const string RDUKID = "RDUKID";

        /// <summary>
        /// RDLNID.
        /// </summary>
        public const string RDLNID = "RDLNID";

        /// <summary>
        /// RDI75GSTNO.
        /// </summary>
        public const string RDI75GSTNO = "RDI75GSTNO";

        /// <summary>
        /// RDALPH.
        /// </summary>
        public const string RDALPH = "RDALPH";

        /// <summary>
        /// RDI75IPOS.
        /// </summary>
        public const string RDI75IPOS = "RDI75IPOS";

        /// <summary>
        /// RDDL01.
        /// </summary>
        public const string RDDL01 = "RDDL01";

        /// <summary>
        /// RDI75INVNO.
        /// </summary>
        public const string RDI75INVNO = "RDI75INVNO";

        /// <summary>
        /// RDDIVJ.
        /// </summary>
        public const string RDDIVJ = "RDDIVJ";

        /// <summary>
        /// RDI75INVVL.
        /// </summary>
        public const string RDI75INVVL = "RDI75INVVL";

        /// <summary>
        /// RDI75CATTY.
        /// </summary>
        public const string RDI75CATTY = "RDI75CATTY";

        /// <summary>
        /// RDI75CATVL.
        /// </summary>
        public const string RDI75CATVL = "RDI75CATVL";

        /// <summary>
        /// RDI75GSTRA.
        /// </summary>
        public const string RDI75GSTRA = "RDI75GSTRA";

        /// <summary>
        /// RDATXA.
        /// </summary>
        public const string RDATXA = "RDATXA";

        /// <summary>
        /// RDI75IGSTA.
        /// </summary>
        public const string RDI75IGSTA = "RDI75IGSTA";

        /// <summary>
        /// RDI75CGSTA.
        /// </summary>
        public const string RDI75CGSTA = "RDI75CGSTA";

        /// <summary>
        /// RDI75SGSTA.
        /// </summary>
        public const string RDI75SGSTA = "RDI75SGSTA";

        /// <summary>
        /// RDI75CESSA.
        /// </summary>
        public const string RDI75CESSA = "RDI75CESSA";

        /// <summary>
        /// RDI75SPACN.
        /// </summary>
        public const string RDI75SPACN = "RDI75SPACN";

        /// <summary>
        /// RDI75SUBDT.
        /// </summary>
        public const string RDI75SUBDT = "RDI75SUBDT";

        /// <summary>
        /// RDI75ITCAF.
        /// </summary>
        public const string RDI75ITCAF = "RDI75ITCAF";

        /// <summary>
        /// RDI75CLMFD.
        /// </summary>
        public const string RDI75CLMFD = "RDI75CLMFD";

        /// <summary>
        /// RDI75CLMDT.
        /// </summary>
        public const string RDI75CLMDT = "RDI75CLMDT";

        /// <summary>
        /// RDI75SECN.
        /// </summary>
        public const string RDI75SECN = "RDI75SECN";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDYFUTDT.
        /// </summary>
        public const string RDYFUTDT = "RDYFUTDT";

        /// <summary>
        /// RDFFU4.
        /// </summary>
        public const string RDFFU4 = "RDFFU4";

        /// <summary>
        /// RDFUT3.
        /// </summary>
        public const string RDFUT3 = "RDFUT3";

        /// <summary>
        /// RDX2.
        /// </summary>
        public const string RDX2 = "RDX2";

        /// <summary>
        /// RDFUTCH1.
        /// </summary>
        public const string RDFUTCH1 = "RDFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I862";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDUKID", "RDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDLNID", "RDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDI75GSTNO", "RDI75GSTNO", JdeDataType.String, 50),
        new JdeField("RDALPH", "RDALPH", JdeDataType.String, 80),
        new JdeField("RDI75IPOS", "RDI75IPOS", JdeDataType.String, 4),
        new JdeField("RDDL01", "RDDL01", JdeDataType.String, 60),
        new JdeField("RDI75INVNO", "RDI75INVNO", JdeDataType.String, 50),
        new JdeField("RDDIVJ", "RDDIVJ", JdeDataType.Numeric),
        new JdeField("RDI75INVVL", "RDI75INVVL", JdeDataType.Numeric),
        new JdeField("RDI75CATTY", "RDI75CATTY", JdeDataType.String, 6),
        new JdeField("RDI75CATVL", "RDI75CATVL", JdeDataType.String, 40),
        new JdeField("RDI75GSTRA", "RDI75GSTRA", JdeDataType.String, 4),
        new JdeField("RDATXA", "RDATXA", JdeDataType.Numeric),
        new JdeField("RDI75IGSTA", "RDI75IGSTA", JdeDataType.Numeric),
        new JdeField("RDI75CGSTA", "RDI75CGSTA", JdeDataType.Numeric),
        new JdeField("RDI75SGSTA", "RDI75SGSTA", JdeDataType.Numeric),
        new JdeField("RDI75CESSA", "RDI75CESSA", JdeDataType.Numeric),
        new JdeField("RDI75SPACN", "RDI75SPACN", JdeDataType.String, 2),
        new JdeField("RDI75SUBDT", "RDI75SUBDT", JdeDataType.Numeric),
        new JdeField("RDI75ITCAF", "RDI75ITCAF", JdeDataType.String, 2),
        new JdeField("RDI75CLMFD", "RDI75CLMFD", JdeDataType.String, 2),
        new JdeField("RDI75CLMDT", "RDI75CLMDT", JdeDataType.Numeric),
        new JdeField("RDI75SECN", "RDI75SECN", JdeDataType.String, 8),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDYFUTDT", "RDYFUTDT", JdeDataType.Numeric),
        new JdeField("RDFFU4", "RDFFU4", JdeDataType.Numeric),
        new JdeField("RDFUT3", "RDFUT3", JdeDataType.String, 60),
        new JdeField("RDX2", "RDX2", JdeDataType.String, 2),
        new JdeField("RDFUTCH1", "RDFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I862_0", "Primary Key on RDUKID, RDLNID", new[] { "RDUKID", "RDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I862_2", "Index on RDUKID, SYS_NC00034$", new[] { "RDUKID", "SYS_NC00034$" })
    };
}
