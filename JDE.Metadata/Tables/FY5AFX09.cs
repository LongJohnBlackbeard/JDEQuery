using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX09 - .
/// </summary>
public class FY5AFX09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIY5AFTMPL.
        /// </summary>
        public const string DIY5AFTMPL = "DIY5AFTMPL";

        /// <summary>
        /// DIY5AFTYPE.
        /// </summary>
        public const string DIY5AFTYPE = "DIY5AFTYPE";

        /// <summary>
        /// DIY5AFPNME.
        /// </summary>
        public const string DIY5AFPNME = "DIY5AFPNME";

        /// <summary>
        /// DIDS01.
        /// </summary>
        public const string DIDS01 = "DIDS01";

        /// <summary>
        /// DICTR.
        /// </summary>
        public const string DICTR = "DICTR";

        /// <summary>
        /// DIDEPT.
        /// </summary>
        public const string DIDEPT = "DIDEPT";

        /// <summary>
        /// DIY5AFCLVL.
        /// </summary>
        public const string DIY5AFCLVL = "DIY5AFCLVL";

        /// <summary>
        /// DIY5AFBILD.
        /// </summary>
        public const string DIY5AFBILD = "DIY5AFBILD";

        /// <summary>
        /// DIY5AFCNF.
        /// </summary>
        public const string DIY5AFCNF = "DIY5AFCNF";

        /// <summary>
        /// DIY5AFSEC.
        /// </summary>
        public const string DIY5AFSEC = "DIY5AFSEC";

        /// <summary>
        /// DIY5AFPCMP.
        /// </summary>
        public const string DIY5AFPCMP = "DIY5AFPCMP";

        /// <summary>
        /// DIUSRALPH.
        /// </summary>
        public const string DIUSRALPH = "DIUSRALPH";

        /// <summary>
        /// DIURC1.
        /// </summary>
        public const string DIURC1 = "DIURC1";

        /// <summary>
        /// DIURDT.
        /// </summary>
        public const string DIURDT = "DIURDT";

        /// <summary>
        /// DICRTU.
        /// </summary>
        public const string DICRTU = "DICRTU";

        /// <summary>
        /// DICADT.
        /// </summary>
        public const string DICADT = "DICADT";

        /// <summary>
        /// DIMUSE.
        /// </summary>
        public const string DIMUSE = "DIMUSE";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIY5AFTMPL", "DIY5AFTMPL", JdeDataType.String, 20, true, true),
        new JdeField("DIY5AFTYPE", "DIY5AFTYPE", JdeDataType.String, 2, true, true),
        new JdeField("DIY5AFPNME", "DIY5AFPNME", JdeDataType.String, 20, true, true),
        new JdeField("DIDS01", "DIDS01", JdeDataType.String, 160),
        new JdeField("DICTR", "DICTR", JdeDataType.String, 6),
        new JdeField("DIDEPT", "DIDEPT", JdeDataType.String, 24),
        new JdeField("DIY5AFCLVL", "DIY5AFCLVL", JdeDataType.String, 2),
        new JdeField("DIY5AFBILD", "DIY5AFBILD", JdeDataType.String, 2),
        new JdeField("DIY5AFCNF", "DIY5AFCNF", JdeDataType.String, 2),
        new JdeField("DIY5AFSEC", "DIY5AFSEC", JdeDataType.String, 2),
        new JdeField("DIY5AFPCMP", "DIY5AFPCMP", JdeDataType.String, 20),
        new JdeField("DIUSRALPH", "DIUSRALPH", JdeDataType.String, 60),
        new JdeField("DIURC1", "DIURC1", JdeDataType.String, 6),
        new JdeField("DIURDT", "DIURDT", JdeDataType.Numeric),
        new JdeField("DICRTU", "DICRTU", JdeDataType.String, 20),
        new JdeField("DICADT", "DICADT", JdeDataType.Numeric),
        new JdeField("DIMUSE", "DIMUSE", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX09_0", "Primary Key on DIY5AFTMPL, DIY5AFTYPE, DIY5AFPNME", new[] { "DIY5AFTMPL", "DIY5AFTYPE", "DIY5AFPNME" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX09_2", "Index on DIY5AFTMPL, DIY5AFPNME", new[] { "DIY5AFTMPL", "DIY5AFPNME" })
    };
}
