using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10430 - .
/// </summary>
public class F10430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFOTPA.
        /// </summary>
        public const string CFOTPA = "CFOTPA";

        /// <summary>
        /// CFCSRT.
        /// </summary>
        public const string CFCSRT = "CFCSRT";

        /// <summary>
        /// CFOBJ.
        /// </summary>
        public const string CFOBJ = "CFOBJ";

        /// <summary>
        /// CFSUB.
        /// </summary>
        public const string CFSUB = "CFSUB";

        /// <summary>
        /// CFTOBJ.
        /// </summary>
        public const string CFTOBJ = "CFTOBJ";

        /// <summary>
        /// CFTSUB.
        /// </summary>
        public const string CFTSUB = "CFTSUB";

        /// <summary>
        /// CFDL01.
        /// </summary>
        public const string CFDL01 = "CFDL01";

        /// <summary>
        /// CFLDA.
        /// </summary>
        public const string CFLDA = "CFLDA";

        /// <summary>
        /// CFAID.
        /// </summary>
        public const string CFAID = "CFAID";

        /// <summary>
        /// CFPEC.
        /// </summary>
        public const string CFPEC = "CFPEC";

        /// <summary>
        /// CFR001.
        /// </summary>
        public const string CFR001 = "CFR001";

        /// <summary>
        /// CFR002.
        /// </summary>
        public const string CFR002 = "CFR002";

        /// <summary>
        /// CFR003.
        /// </summary>
        public const string CFR003 = "CFR003";

        /// <summary>
        /// CFR004.
        /// </summary>
        public const string CFR004 = "CFR004";

        /// <summary>
        /// CFR005.
        /// </summary>
        public const string CFR005 = "CFR005";

        /// <summary>
        /// CFR006.
        /// </summary>
        public const string CFR006 = "CFR006";

        /// <summary>
        /// CFR007.
        /// </summary>
        public const string CFR007 = "CFR007";

        /// <summary>
        /// CFR008.
        /// </summary>
        public const string CFR008 = "CFR008";

        /// <summary>
        /// CFR009.
        /// </summary>
        public const string CFR009 = "CFR009";

        /// <summary>
        /// CFR010.
        /// </summary>
        public const string CFR010 = "CFR010";

        /// <summary>
        /// CFR011.
        /// </summary>
        public const string CFR011 = "CFR011";

        /// <summary>
        /// CFR012.
        /// </summary>
        public const string CFR012 = "CFR012";

        /// <summary>
        /// CFR013.
        /// </summary>
        public const string CFR013 = "CFR013";

        /// <summary>
        /// CFR014.
        /// </summary>
        public const string CFR014 = "CFR014";

        /// <summary>
        /// CFR015.
        /// </summary>
        public const string CFR015 = "CFR015";

        /// <summary>
        /// CFR016.
        /// </summary>
        public const string CFR016 = "CFR016";

        /// <summary>
        /// CFR017.
        /// </summary>
        public const string CFR017 = "CFR017";

        /// <summary>
        /// CFR018.
        /// </summary>
        public const string CFR018 = "CFR018";

        /// <summary>
        /// CFR019.
        /// </summary>
        public const string CFR019 = "CFR019";

        /// <summary>
        /// CFR020.
        /// </summary>
        public const string CFR020 = "CFR020";

        /// <summary>
        /// CFR021.
        /// </summary>
        public const string CFR021 = "CFR021";

        /// <summary>
        /// CFR022.
        /// </summary>
        public const string CFR022 = "CFR022";

        /// <summary>
        /// CFR023.
        /// </summary>
        public const string CFR023 = "CFR023";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFOTPA", "CFOTPA", JdeDataType.String, 6, true, true),
        new JdeField("CFCSRT", "CFCSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("CFOBJ", "CFOBJ", JdeDataType.String, 12),
        new JdeField("CFSUB", "CFSUB", JdeDataType.String, 16),
        new JdeField("CFTOBJ", "CFTOBJ", JdeDataType.String, 12),
        new JdeField("CFTSUB", "CFTSUB", JdeDataType.String, 16),
        new JdeField("CFDL01", "CFDL01", JdeDataType.String, 60),
        new JdeField("CFLDA", "CFLDA", JdeDataType.String, 2),
        new JdeField("CFAID", "CFAID", JdeDataType.String, 16),
        new JdeField("CFPEC", "CFPEC", JdeDataType.String, 2),
        new JdeField("CFR001", "CFR001", JdeDataType.String, 6),
        new JdeField("CFR002", "CFR002", JdeDataType.String, 6),
        new JdeField("CFR003", "CFR003", JdeDataType.String, 6),
        new JdeField("CFR004", "CFR004", JdeDataType.String, 6),
        new JdeField("CFR005", "CFR005", JdeDataType.String, 6),
        new JdeField("CFR006", "CFR006", JdeDataType.String, 6),
        new JdeField("CFR007", "CFR007", JdeDataType.String, 6),
        new JdeField("CFR008", "CFR008", JdeDataType.String, 6),
        new JdeField("CFR009", "CFR009", JdeDataType.String, 6),
        new JdeField("CFR010", "CFR010", JdeDataType.String, 6),
        new JdeField("CFR011", "CFR011", JdeDataType.String, 6),
        new JdeField("CFR012", "CFR012", JdeDataType.String, 6),
        new JdeField("CFR013", "CFR013", JdeDataType.String, 6),
        new JdeField("CFR014", "CFR014", JdeDataType.String, 6),
        new JdeField("CFR015", "CFR015", JdeDataType.String, 6),
        new JdeField("CFR016", "CFR016", JdeDataType.String, 6),
        new JdeField("CFR017", "CFR017", JdeDataType.String, 6),
        new JdeField("CFR018", "CFR018", JdeDataType.String, 6),
        new JdeField("CFR019", "CFR019", JdeDataType.String, 6),
        new JdeField("CFR020", "CFR020", JdeDataType.String, 6),
        new JdeField("CFR021", "CFR021", JdeDataType.String, 20),
        new JdeField("CFR022", "CFR022", JdeDataType.String, 20),
        new JdeField("CFR023", "CFR023", JdeDataType.String, 20),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10430_0", "Primary Key on CFOTPA, CFCSRT", new[] { "CFOTPA", "CFCSRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10430_2", "Index on CFOTPA, CFOBJ, CFSUB", new[] { "CFOTPA", "CFOBJ", "CFSUB" }),
        new JdeIndex("F10430_3", "Index on CFOTPA", new[] { "CFOTPA" })
    };
}
