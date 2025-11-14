using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0002 - .
/// </summary>
public class F75A0002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZOCCPR.
        /// </summary>
        public const string ZOCCPR = "ZOCCPR";

        /// <summary>
        /// ZOEDTF.
        /// </summary>
        public const string ZOEDTF = "ZOEDTF";

        /// <summary>
        /// ZOEDTT.
        /// </summary>
        public const string ZOEDTT = "ZOEDTT";

        /// <summary>
        /// ZOSCALE.
        /// </summary>
        public const string ZOSCALE = "ZOSCALE";

        /// <summary>
        /// ZONOWEEK.
        /// </summary>
        public const string ZONOWEEK = "ZONOWEEK";

        /// <summary>
        /// ZOWKLREB.
        /// </summary>
        public const string ZOWKLREB = "ZOWKLREB";

        /// <summary>
        /// ZOFRCENT.
        /// </summary>
        public const string ZOFRCENT = "ZOFRCENT";

        /// <summary>
        /// ZOADCHILD.
        /// </summary>
        public const string ZOADCHILD = "ZOADCHILD";

        /// <summary>
        /// ZOMDFAMT.
        /// </summary>
        public const string ZOMDFAMT = "ZOMDFAMT";

        /// <summary>
        /// ZOWKERNT.
        /// </summary>
        public const string ZOWKERNT = "ZOWKERNT";

        /// <summary>
        /// ZOWERNST.
        /// </summary>
        public const string ZOWERNST = "ZOWERNST";

        /// <summary>
        /// ZOSOPMUL.
        /// </summary>
        public const string ZOSOPMUL = "ZOSOPMUL";

        /// <summary>
        /// ZOSOPDIV.
        /// </summary>
        public const string ZOSOPDIV = "ZOSOPDIV";

        /// <summary>
        /// ZOWLAFAC.
        /// </summary>
        public const string ZOWLAFAC = "ZOWLAFAC";

        /// <summary>
        /// ZOMEDLEV.
        /// </summary>
        public const string ZOMEDLEV = "ZOMEDLEV";

        /// <summary>
        /// ZOSUPRTE.
        /// </summary>
        public const string ZOSUPRTE = "ZOSUPRTE";

        /// <summary>
        /// ZOCASBCDE.
        /// </summary>
        public const string ZOCASBCDE = "ZOCASBCDE";

        /// <summary>
        /// ZOCASDCDE.
        /// </summary>
        public const string ZOCASDCDE = "ZOCASDCDE";

        /// <summary>
        /// ZOCASRUNT.
        /// </summary>
        public const string ZOCASRUNT = "ZOCASRUNT";

        /// <summary>
        /// ZOCSDCDE.
        /// </summary>
        public const string ZOCSDCDE = "ZOCSDCDE";

        /// <summary>
        /// ZOINCLVL1.
        /// </summary>
        public const string ZOINCLVL1 = "ZOINCLVL1";

        /// <summary>
        /// ZOINCLVL2.
        /// </summary>
        public const string ZOINCLVL2 = "ZOINCLVL2";

        /// <summary>
        /// ZOINCLVL3.
        /// </summary>
        public const string ZOINCLVL3 = "ZOINCLVL3";

        /// <summary>
        /// ZOHRSLVL.
        /// </summary>
        public const string ZOHRSLVL = "ZOHRSLVL";

        /// <summary>
        /// ZORATE6.
        /// </summary>
        public const string ZORATE6 = "ZORATE6";

        /// <summary>
        /// ZORATE7.
        /// </summary>
        public const string ZORATE7 = "ZORATE7";

        /// <summary>
        /// ZORATE8.
        /// </summary>
        public const string ZORATE8 = "ZORATE8";

        /// <summary>
        /// ZOUPMJ.
        /// </summary>
        public const string ZOUPMJ = "ZOUPMJ";

        /// <summary>
        /// ZOUPMT.
        /// </summary>
        public const string ZOUPMT = "ZOUPMT";

        /// <summary>
        /// ZOPID.
        /// </summary>
        public const string ZOPID = "ZOPID";

        /// <summary>
        /// ZOJOBN.
        /// </summary>
        public const string ZOJOBN = "ZOJOBN";

        /// <summary>
        /// ZOUSER.
        /// </summary>
        public const string ZOUSER = "ZOUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZOCCPR", "ZOCCPR", JdeDataType.String, 6, true, true),
        new JdeField("ZOEDTF", "ZOEDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("ZOEDTT", "ZOEDTT", JdeDataType.Numeric),
        new JdeField("ZOSCALE", "ZOSCALE", JdeDataType.String, 6, true, true),
        new JdeField("ZONOWEEK", "ZONOWEEK", JdeDataType.Numeric),
        new JdeField("ZOWKLREB", "ZOWKLREB", JdeDataType.Numeric),
        new JdeField("ZOFRCENT", "ZOFRCENT", JdeDataType.Numeric),
        new JdeField("ZOADCHILD", "ZOADCHILD", JdeDataType.Numeric),
        new JdeField("ZOMDFAMT", "ZOMDFAMT", JdeDataType.Numeric),
        new JdeField("ZOWKERNT", "ZOWKERNT", JdeDataType.Numeric),
        new JdeField("ZOWERNST", "ZOWERNST", JdeDataType.Numeric),
        new JdeField("ZOSOPMUL", "ZOSOPMUL", JdeDataType.Numeric),
        new JdeField("ZOSOPDIV", "ZOSOPDIV", JdeDataType.Numeric),
        new JdeField("ZOWLAFAC", "ZOWLAFAC", JdeDataType.Numeric),
        new JdeField("ZOMEDLEV", "ZOMEDLEV", JdeDataType.Numeric),
        new JdeField("ZOSUPRTE", "ZOSUPRTE", JdeDataType.Numeric),
        new JdeField("ZOCASBCDE", "ZOCASBCDE", JdeDataType.Numeric),
        new JdeField("ZOCASDCDE", "ZOCASDCDE", JdeDataType.Numeric),
        new JdeField("ZOCASRUNT", "ZOCASRUNT", JdeDataType.Numeric),
        new JdeField("ZOCSDCDE", "ZOCSDCDE", JdeDataType.Numeric),
        new JdeField("ZOINCLVL1", "ZOINCLVL1", JdeDataType.Numeric),
        new JdeField("ZOINCLVL2", "ZOINCLVL2", JdeDataType.Numeric),
        new JdeField("ZOINCLVL3", "ZOINCLVL3", JdeDataType.Numeric),
        new JdeField("ZOHRSLVL", "ZOHRSLVL", JdeDataType.Numeric),
        new JdeField("ZORATE6", "ZORATE6", JdeDataType.Numeric),
        new JdeField("ZORATE7", "ZORATE7", JdeDataType.Numeric),
        new JdeField("ZORATE8", "ZORATE8", JdeDataType.Numeric),
        new JdeField("ZOUPMJ", "ZOUPMJ", JdeDataType.Numeric),
        new JdeField("ZOUPMT", "ZOUPMT", JdeDataType.Numeric),
        new JdeField("ZOPID", "ZOPID", JdeDataType.String, 20),
        new JdeField("ZOJOBN", "ZOJOBN", JdeDataType.String, 20),
        new JdeField("ZOUSER", "ZOUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0002_0", "Primary Key on ZOCCPR, ZOEDTF, ZOSCALE", new[] { "ZOCCPR", "ZOEDTF", "ZOSCALE" }, isUnique: true, isPrimaryKey: true)
    };
}
