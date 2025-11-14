using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09626 - .
/// </summary>
public class F09626 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRRECRULE.
        /// </summary>
        public const string GRRECRULE = "GRRECRULE";

        /// <summary>
        /// GRSTRN.
        /// </summary>
        public const string GRSTRN = "GRSTRN";

        /// <summary>
        /// GRDL01.
        /// </summary>
        public const string GRDL01 = "GRDL01";

        /// <summary>
        /// GRDCTM.
        /// </summary>
        public const string GRDCTM = "GRDCTM";

        /// <summary>
        /// GRRECCODE.
        /// </summary>
        public const string GRRECCODE = "GRRECCODE";

        /// <summary>
        /// GRVALGLFLG.
        /// </summary>
        public const string GRVALGLFLG = "GRVALGLFLG";

        /// <summary>
        /// GRDATEGL.
        /// </summary>
        public const string GRDATEGL = "GRDATEGL";

        /// <summary>
        /// GRGLOFFSET.
        /// </summary>
        public const string GRGLOFFSET = "GRGLOFFSET";

        /// <summary>
        /// GRABRF.
        /// </summary>
        public const string GRABRF = "GRABRF";

        /// <summary>
        /// GRABRDATE.
        /// </summary>
        public const string GRABRDATE = "GRABRDATE";

        /// <summary>
        /// GRADCC.
        /// </summary>
        public const string GRADCC = "GRADCC";

        /// <summary>
        /// GRADCDATE.
        /// </summary>
        public const string GRADCDATE = "GRADCDATE";

        /// <summary>
        /// GRCAPFLG.
        /// </summary>
        public const string GRCAPFLG = "GRCAPFLG";

        /// <summary>
        /// GRAPDATE.
        /// </summary>
        public const string GRAPDATE = "GRAPDATE";

        /// <summary>
        /// GRVARFLG.
        /// </summary>
        public const string GRVARFLG = "GRVARFLG";

        /// <summary>
        /// GRVARACCT.
        /// </summary>
        public const string GRVARACCT = "GRVARACCT";

        /// <summary>
        /// GRVARDATE.
        /// </summary>
        public const string GRVARDATE = "GRVARDATE";

        /// <summary>
        /// GRTOLIMIT.
        /// </summary>
        public const string GRTOLIMIT = "GRTOLIMIT";

        /// <summary>
        /// GRTRNACCT.
        /// </summary>
        public const string GRTRNACCT = "GRTRNACCT";

        /// <summary>
        /// GRGNLSFLG.
        /// </summary>
        public const string GRGNLSFLG = "GRGNLSFLG";

        /// <summary>
        /// GRGNLSDATE.
        /// </summary>
        public const string GRGNLSDATE = "GRGNLSDATE";

        /// <summary>
        /// GRFLG01.
        /// </summary>
        public const string GRFLG01 = "GRFLG01";

        /// <summary>
        /// GRFLG02.
        /// </summary>
        public const string GRFLG02 = "GRFLG02";

        /// <summary>
        /// GRDATEFLG1.
        /// </summary>
        public const string GRDATEFLG1 = "GRDATEFLG1";

        /// <summary>
        /// GRDATEFLG2.
        /// </summary>
        public const string GRDATEFLG2 = "GRDATEFLG2";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09626";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRRECRULE", "GRRECRULE", JdeDataType.String, 20, true, true),
        new JdeField("GRSTRN", "GRSTRN", JdeDataType.String, 6, true, true),
        new JdeField("GRDL01", "GRDL01", JdeDataType.String, 60),
        new JdeField("GRDCTM", "GRDCTM", JdeDataType.String, 4),
        new JdeField("GRRECCODE", "GRRECCODE", JdeDataType.String, 2),
        new JdeField("GRVALGLFLG", "GRVALGLFLG", JdeDataType.String, 2),
        new JdeField("GRDATEGL", "GRDATEGL", JdeDataType.String, 2),
        new JdeField("GRGLOFFSET", "GRGLOFFSET", JdeDataType.String, 16),
        new JdeField("GRABRF", "GRABRF", JdeDataType.String, 2),
        new JdeField("GRABRDATE", "GRABRDATE", JdeDataType.String, 2),
        new JdeField("GRADCC", "GRADCC", JdeDataType.String, 2),
        new JdeField("GRADCDATE", "GRADCDATE", JdeDataType.String, 2),
        new JdeField("GRCAPFLG", "GRCAPFLG", JdeDataType.String, 2),
        new JdeField("GRAPDATE", "GRAPDATE", JdeDataType.String, 2),
        new JdeField("GRVARFLG", "GRVARFLG", JdeDataType.String, 2),
        new JdeField("GRVARACCT", "GRVARACCT", JdeDataType.String, 16),
        new JdeField("GRVARDATE", "GRVARDATE", JdeDataType.String, 2),
        new JdeField("GRTOLIMIT", "GRTOLIMIT", JdeDataType.String, 20),
        new JdeField("GRTRNACCT", "GRTRNACCT", JdeDataType.String, 58),
        new JdeField("GRGNLSFLG", "GRGNLSFLG", JdeDataType.String, 2),
        new JdeField("GRGNLSDATE", "GRGNLSDATE", JdeDataType.String, 2),
        new JdeField("GRFLG01", "GRFLG01", JdeDataType.String, 2),
        new JdeField("GRFLG02", "GRFLG02", JdeDataType.String, 2),
        new JdeField("GRDATEFLG1", "GRDATEFLG1", JdeDataType.String, 2),
        new JdeField("GRDATEFLG2", "GRDATEFLG2", JdeDataType.String, 2),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09626_0", "Primary Key on GRRECRULE, GRSTRN", new[] { "GRRECRULE", "GRSTRN" }, isUnique: true, isPrimaryKey: true)
    };
}
