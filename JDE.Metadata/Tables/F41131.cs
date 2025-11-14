using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41131 - .
/// </summary>
public class F41131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IUUKID.
        /// </summary>
        public const string IUUKID = "IUUKID";

        /// <summary>
        /// IUITM.
        /// </summary>
        public const string IUITM = "IUITM";

        /// <summary>
        /// IULOTN.
        /// </summary>
        public const string IULOTN = "IULOTN";

        /// <summary>
        /// IUTLOT.
        /// </summary>
        public const string IUTLOT = "IUTLOT";

        /// <summary>
        /// IUPLOT.
        /// </summary>
        public const string IUPLOT = "IUPLOT";

        /// <summary>
        /// IULOTC.
        /// </summary>
        public const string IULOTC = "IULOTC";

        /// <summary>
        /// IUMMEA.
        /// </summary>
        public const string IUMMEA = "IUMMEA";

        /// <summary>
        /// IUMCU.
        /// </summary>
        public const string IUMCU = "IUMCU";

        /// <summary>
        /// IUTOMCU.
        /// </summary>
        public const string IUTOMCU = "IUTOMCU";

        /// <summary>
        /// IUCO.
        /// </summary>
        public const string IUCO = "IUCO";

        /// <summary>
        /// IUFLOC.
        /// </summary>
        public const string IUFLOC = "IUFLOC";

        /// <summary>
        /// IUTLOC.
        /// </summary>
        public const string IUTLOC = "IUTLOC";

        /// <summary>
        /// IUDOC.
        /// </summary>
        public const string IUDOC = "IUDOC";

        /// <summary>
        /// IUDCT.
        /// </summary>
        public const string IUDCT = "IUDCT";

        /// <summary>
        /// IULNID.
        /// </summary>
        public const string IULNID = "IULNID";

        /// <summary>
        /// IURFLN.
        /// </summary>
        public const string IURFLN = "IURFLN";

        /// <summary>
        /// IUTGN.
        /// </summary>
        public const string IUTGN = "IUTGN";

        /// <summary>
        /// IUTREX.
        /// </summary>
        public const string IUTREX = "IUTREX";

        /// <summary>
        /// IUUORG.
        /// </summary>
        public const string IUUORG = "IUUORG";

        /// <summary>
        /// IUUOM.
        /// </summary>
        public const string IUUOM = "IUUOM";

        /// <summary>
        /// IUATRD.
        /// </summary>
        public const string IUATRD = "IUATRD";

        /// <summary>
        /// IUAN8.
        /// </summary>
        public const string IUAN8 = "IUAN8";

        /// <summary>
        /// IUUSER.
        /// </summary>
        public const string IUUSER = "IUUSER";

        /// <summary>
        /// IUPID.
        /// </summary>
        public const string IUPID = "IUPID";

        /// <summary>
        /// IUJOBN.
        /// </summary>
        public const string IUJOBN = "IUJOBN";

        /// <summary>
        /// IUUPMJ.
        /// </summary>
        public const string IUUPMJ = "IUUPMJ";

        /// <summary>
        /// IUTDAY.
        /// </summary>
        public const string IUTDAY = "IUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IUUKID", "IUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IUITM", "IUITM", JdeDataType.Numeric),
        new JdeField("IULOTN", "IULOTN", JdeDataType.String, 60),
        new JdeField("IUTLOT", "IUTLOT", JdeDataType.String, 60),
        new JdeField("IUPLOT", "IUPLOT", JdeDataType.String, 60),
        new JdeField("IULOTC", "IULOTC", JdeDataType.String, 6),
        new JdeField("IUMMEA", "IUMMEA", JdeDataType.String, 20),
        new JdeField("IUMCU", "IUMCU", JdeDataType.String, 24),
        new JdeField("IUTOMCU", "IUTOMCU", JdeDataType.String, 24),
        new JdeField("IUCO", "IUCO", JdeDataType.String, 10),
        new JdeField("IUFLOC", "IUFLOC", JdeDataType.String, 40),
        new JdeField("IUTLOC", "IUTLOC", JdeDataType.String, 40),
        new JdeField("IUDOC", "IUDOC", JdeDataType.Numeric),
        new JdeField("IUDCT", "IUDCT", JdeDataType.String, 4),
        new JdeField("IULNID", "IULNID", JdeDataType.Numeric),
        new JdeField("IURFLN", "IURFLN", JdeDataType.Numeric),
        new JdeField("IUTGN", "IUTGN", JdeDataType.Numeric),
        new JdeField("IUTREX", "IUTREX", JdeDataType.String, 60),
        new JdeField("IUUORG", "IUUORG", JdeDataType.Numeric),
        new JdeField("IUUOM", "IUUOM", JdeDataType.String, 4),
        new JdeField("IUATRD", "IUATRD", JdeDataType.Numeric),
        new JdeField("IUAN8", "IUAN8", JdeDataType.Numeric),
        new JdeField("IUUSER", "IUUSER", JdeDataType.String, 20),
        new JdeField("IUPID", "IUPID", JdeDataType.String, 20),
        new JdeField("IUJOBN", "IUJOBN", JdeDataType.String, 20),
        new JdeField("IUUPMJ", "IUUPMJ", JdeDataType.Numeric),
        new JdeField("IUTDAY", "IUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41131_0", "Primary Key on IUUKID", new[] { "IUUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
