using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1538B1 - .
/// </summary>
public class F1538B1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GUICU.
        /// </summary>
        public const string GUICU = "GUICU";

        /// <summary>
        /// GUDOCO.
        /// </summary>
        public const string GUDOCO = "GUDOCO";

        /// <summary>
        /// GULSVR.
        /// </summary>
        public const string GULSVR = "GULSVR";

        /// <summary>
        /// GUEPCL.
        /// </summary>
        public const string GUEPCL = "GUEPCL";

        /// <summary>
        /// GUBCI.
        /// </summary>
        public const string GUBCI = "GUBCI";

        /// <summary>
        /// GUAID.
        /// </summary>
        public const string GUAID = "GUAID";

        /// <summary>
        /// GUMCU.
        /// </summary>
        public const string GUMCU = "GUMCU";

        /// <summary>
        /// GUOBJ.
        /// </summary>
        public const string GUOBJ = "GUOBJ";

        /// <summary>
        /// GUSUB.
        /// </summary>
        public const string GUSUB = "GUSUB";

        /// <summary>
        /// GUSBL.
        /// </summary>
        public const string GUSBL = "GUSBL";

        /// <summary>
        /// GUSBLT.
        /// </summary>
        public const string GUSBLT = "GUSBLT";

        /// <summary>
        /// GUGUBSEX.
        /// </summary>
        public const string GUGUBSEX = "GUGUBSEX";

        /// <summary>
        /// GUSTGU.
        /// </summary>
        public const string GUSTGU = "GUSTGU";

        /// <summary>
        /// GUVPCTGU.
        /// </summary>
        public const string GUVPCTGU = "GUVPCTGU";

        /// <summary>
        /// GUOCTYPE.
        /// </summary>
        public const string GUOCTYPE = "GUOCTYPE";

        /// <summary>
        /// GUGUBSVA.
        /// </summary>
        public const string GUGUBSVA = "GUGUBSVA";

        /// <summary>
        /// GUGPCT.
        /// </summary>
        public const string GUGPCT = "GUGPCT";

        /// <summary>
        /// GUGUOCPC.
        /// </summary>
        public const string GUGUOCPC = "GUGUOCPC";

        /// <summary>
        /// GUGUFCTR.
        /// </summary>
        public const string GUGUFCTR = "GUGUFCTR";

        /// <summary>
        /// GUGUVARA.
        /// </summary>
        public const string GUGUVARA = "GUGUVARA";

        /// <summary>
        /// GUGUFIXA.
        /// </summary>
        public const string GUGUFIXA = "GUGUFIXA";

        /// <summary>
        /// GUGUACCT.
        /// </summary>
        public const string GUGUACCT = "GUGUACCT";

        /// <summary>
        /// GUGUAADJ.
        /// </summary>
        public const string GUGUAADJ = "GUGUAADJ";

        /// <summary>
        /// GUCRCD.
        /// </summary>
        public const string GUCRCD = "GUCRCD";

        /// <summary>
        /// GUURCD.
        /// </summary>
        public const string GUURCD = "GUURCD";

        /// <summary>
        /// GUURDT.
        /// </summary>
        public const string GUURDT = "GUURDT";

        /// <summary>
        /// GUURAT.
        /// </summary>
        public const string GUURAT = "GUURAT";

        /// <summary>
        /// GUURAB.
        /// </summary>
        public const string GUURAB = "GUURAB";

        /// <summary>
        /// GUURRF.
        /// </summary>
        public const string GUURRF = "GUURRF";

        /// <summary>
        /// GUUSER.
        /// </summary>
        public const string GUUSER = "GUUSER";

        /// <summary>
        /// GUPID.
        /// </summary>
        public const string GUPID = "GUPID";

        /// <summary>
        /// GUMKEY.
        /// </summary>
        public const string GUMKEY = "GUMKEY";

        /// <summary>
        /// GUUPMJ.
        /// </summary>
        public const string GUUPMJ = "GUUPMJ";

        /// <summary>
        /// GUUPMT.
        /// </summary>
        public const string GUUPMT = "GUUPMT";

        /// <summary>
        /// GUTORG.
        /// </summary>
        public const string GUTORG = "GUTORG";

        /// <summary>
        /// GUENTJ.
        /// </summary>
        public const string GUENTJ = "GUENTJ";

        /// <summary>
        /// GUEFTB.
        /// </summary>
        public const string GUEFTB = "GUEFTB";

        /// <summary>
        /// GUEFTE.
        /// </summary>
        public const string GUEFTE = "GUEFTE";

        /// <summary>
        /// GUGUPRF.
        /// </summary>
        public const string GUGUPRF = "GUGUPRF";
    }

    /// <inheritdoc />
    public override string TableName => "F1538B1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GUICU", "GUICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GUDOCO", "GUDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("GULSVR", "GULSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("GUEPCL", "GUEPCL", JdeDataType.String, 8, true, true),
        new JdeField("GUBCI", "GUBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("GUAID", "GUAID", JdeDataType.String, 16, true, true),
        new JdeField("GUMCU", "GUMCU", JdeDataType.String, 24),
        new JdeField("GUOBJ", "GUOBJ", JdeDataType.String, 12),
        new JdeField("GUSUB", "GUSUB", JdeDataType.String, 16),
        new JdeField("GUSBL", "GUSBL", JdeDataType.String, 16, true, true),
        new JdeField("GUSBLT", "GUSBLT", JdeDataType.String, 2),
        new JdeField("GUGUBSEX", "GUGUBSEX", JdeDataType.Numeric),
        new JdeField("GUSTGU", "GUSTGU", JdeDataType.String, 2),
        new JdeField("GUVPCTGU", "GUVPCTGU", JdeDataType.Numeric),
        new JdeField("GUOCTYPE", "GUOCTYPE", JdeDataType.String, 2),
        new JdeField("GUGUBSVA", "GUGUBSVA", JdeDataType.Numeric),
        new JdeField("GUGPCT", "GUGPCT", JdeDataType.Numeric),
        new JdeField("GUGUOCPC", "GUGUOCPC", JdeDataType.Numeric),
        new JdeField("GUGUFCTR", "GUGUFCTR", JdeDataType.Numeric),
        new JdeField("GUGUVARA", "GUGUVARA", JdeDataType.Numeric),
        new JdeField("GUGUFIXA", "GUGUFIXA", JdeDataType.Numeric),
        new JdeField("GUGUACCT", "GUGUACCT", JdeDataType.Numeric),
        new JdeField("GUGUAADJ", "GUGUAADJ", JdeDataType.Numeric),
        new JdeField("GUCRCD", "GUCRCD", JdeDataType.String, 6),
        new JdeField("GUURCD", "GUURCD", JdeDataType.String, 4),
        new JdeField("GUURDT", "GUURDT", JdeDataType.Numeric),
        new JdeField("GUURAT", "GUURAT", JdeDataType.Numeric),
        new JdeField("GUURAB", "GUURAB", JdeDataType.Numeric),
        new JdeField("GUURRF", "GUURRF", JdeDataType.String, 30),
        new JdeField("GUUSER", "GUUSER", JdeDataType.String, 20),
        new JdeField("GUPID", "GUPID", JdeDataType.String, 20),
        new JdeField("GUMKEY", "GUMKEY", JdeDataType.String, 30),
        new JdeField("GUUPMJ", "GUUPMJ", JdeDataType.Numeric),
        new JdeField("GUUPMT", "GUUPMT", JdeDataType.Numeric),
        new JdeField("GUTORG", "GUTORG", JdeDataType.String, 20),
        new JdeField("GUENTJ", "GUENTJ", JdeDataType.Numeric),
        new JdeField("GUEFTB", "GUEFTB", JdeDataType.Numeric),
        new JdeField("GUEFTE", "GUEFTE", JdeDataType.Numeric),
        new JdeField("GUGUPRF", "GUGUPRF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1538B1_0", "Primary Key on GUICU, GUDOCO, GULSVR, GUEPCL, GUBCI, GUAID, GUSBL", new[] { "GUICU", "GUDOCO", "GULSVR", "GUEPCL", "GUBCI", "GUAID", "GUSBL" }, isUnique: true, isPrimaryKey: true)
    };
}
