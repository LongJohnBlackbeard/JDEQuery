using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1539E - .
/// </summary>
public class F1539E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AUICU.
        /// </summary>
        public const string AUICU = "AUICU";

        /// <summary>
        /// AUDOCO.
        /// </summary>
        public const string AUDOCO = "AUDOCO";

        /// <summary>
        /// AULSVR.
        /// </summary>
        public const string AULSVR = "AULSVR";

        /// <summary>
        /// AUEPCL.
        /// </summary>
        public const string AUEPCL = "AUEPCL";

        /// <summary>
        /// AUBCI.
        /// </summary>
        public const string AUBCI = "AUBCI";

        /// <summary>
        /// AULNID.
        /// </summary>
        public const string AULNID = "AULNID";

        /// <summary>
        /// AUCLSX.
        /// </summary>
        public const string AUCLSX = "AUCLSX";

        /// <summary>
        /// AUIOEP.
        /// </summary>
        public const string AUIOEP = "AUIOEP";

        /// <summary>
        /// AUEFTB.
        /// </summary>
        public const string AUEFTB = "AUEFTB";

        /// <summary>
        /// AUEFTE.
        /// </summary>
        public const string AUEFTE = "AUEFTE";

        /// <summary>
        /// AUTSPRF.
        /// </summary>
        public const string AUTSPRF = "AUTSPRF";

        /// <summary>
        /// AUPCLSX.
        /// </summary>
        public const string AUPCLSX = "AUPCLSX";

        /// <summary>
        /// AUACTX.
        /// </summary>
        public const string AUACTX = "AUACTX";

        /// <summary>
        /// AUADJL.
        /// </summary>
        public const string AUADJL = "AUADJL";

        /// <summary>
        /// AUADJTY.
        /// </summary>
        public const string AUADJTY = "AUADJTY";

        /// <summary>
        /// AULVLT.
        /// </summary>
        public const string AULVLT = "AULVLT";

        /// <summary>
        /// AUBCIR.
        /// </summary>
        public const string AUBCIR = "AUBCIR";

        /// <summary>
        /// AUUNIT.
        /// </summary>
        public const string AUUNIT = "AUUNIT";

        /// <summary>
        /// AUAID.
        /// </summary>
        public const string AUAID = "AUAID";

        /// <summary>
        /// AUMCU.
        /// </summary>
        public const string AUMCU = "AUMCU";

        /// <summary>
        /// AUOBJ.
        /// </summary>
        public const string AUOBJ = "AUOBJ";

        /// <summary>
        /// AUSUB.
        /// </summary>
        public const string AUSUB = "AUSUB";

        /// <summary>
        /// AUCRCD.
        /// </summary>
        public const string AUCRCD = "AUCRCD";

        /// <summary>
        /// AUEPMCU.
        /// </summary>
        public const string AUEPMCU = "AUEPMCU";

        /// <summary>
        /// AUURCD.
        /// </summary>
        public const string AUURCD = "AUURCD";

        /// <summary>
        /// AUURDT.
        /// </summary>
        public const string AUURDT = "AUURDT";

        /// <summary>
        /// AUURAT.
        /// </summary>
        public const string AUURAT = "AUURAT";

        /// <summary>
        /// AUURAB.
        /// </summary>
        public const string AUURAB = "AUURAB";

        /// <summary>
        /// AUURRF.
        /// </summary>
        public const string AUURRF = "AUURRF";

        /// <summary>
        /// AUUSER.
        /// </summary>
        public const string AUUSER = "AUUSER";

        /// <summary>
        /// AUPID.
        /// </summary>
        public const string AUPID = "AUPID";

        /// <summary>
        /// AUMKEY.
        /// </summary>
        public const string AUMKEY = "AUMKEY";

        /// <summary>
        /// AUUPMJ.
        /// </summary>
        public const string AUUPMJ = "AUUPMJ";

        /// <summary>
        /// AUUPMT.
        /// </summary>
        public const string AUUPMT = "AUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1539E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AUICU", "AUICU", JdeDataType.Numeric, null, true, true),
        new JdeField("AUDOCO", "AUDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AULSVR", "AULSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("AUEPCL", "AUEPCL", JdeDataType.String, 8, true, true),
        new JdeField("AUBCI", "AUBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("AULNID", "AULNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AUCLSX", "AUCLSX", JdeDataType.Numeric),
        new JdeField("AUIOEP", "AUIOEP", JdeDataType.Numeric),
        new JdeField("AUEFTB", "AUEFTB", JdeDataType.Numeric),
        new JdeField("AUEFTE", "AUEFTE", JdeDataType.Numeric),
        new JdeField("AUTSPRF", "AUTSPRF", JdeDataType.Numeric),
        new JdeField("AUPCLSX", "AUPCLSX", JdeDataType.Numeric),
        new JdeField("AUACTX", "AUACTX", JdeDataType.Numeric),
        new JdeField("AUADJL", "AUADJL", JdeDataType.String, 2),
        new JdeField("AUADJTY", "AUADJTY", JdeDataType.String, 2),
        new JdeField("AULVLT", "AULVLT", JdeDataType.String, 2),
        new JdeField("AUBCIR", "AUBCIR", JdeDataType.Numeric),
        new JdeField("AUUNIT", "AUUNIT", JdeDataType.String, 16),
        new JdeField("AUAID", "AUAID", JdeDataType.String, 16),
        new JdeField("AUMCU", "AUMCU", JdeDataType.String, 24),
        new JdeField("AUOBJ", "AUOBJ", JdeDataType.String, 12),
        new JdeField("AUSUB", "AUSUB", JdeDataType.String, 16),
        new JdeField("AUCRCD", "AUCRCD", JdeDataType.String, 6),
        new JdeField("AUEPMCU", "AUEPMCU", JdeDataType.String, 24),
        new JdeField("AUURCD", "AUURCD", JdeDataType.String, 4),
        new JdeField("AUURDT", "AUURDT", JdeDataType.Numeric),
        new JdeField("AUURAT", "AUURAT", JdeDataType.Numeric),
        new JdeField("AUURAB", "AUURAB", JdeDataType.Numeric),
        new JdeField("AUURRF", "AUURRF", JdeDataType.String, 30),
        new JdeField("AUUSER", "AUUSER", JdeDataType.String, 20),
        new JdeField("AUPID", "AUPID", JdeDataType.String, 20),
        new JdeField("AUMKEY", "AUMKEY", JdeDataType.String, 30),
        new JdeField("AUUPMJ", "AUUPMJ", JdeDataType.Numeric),
        new JdeField("AUUPMT", "AUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1539E_0", "Primary Key on AUICU, AUDOCO, AULSVR, AUEPCL, AUBCI, AULNID", new[] { "AUICU", "AUDOCO", "AULSVR", "AUEPCL", "AUBCI", "AULNID" }, isUnique: true, isPrimaryKey: true)
    };
}
