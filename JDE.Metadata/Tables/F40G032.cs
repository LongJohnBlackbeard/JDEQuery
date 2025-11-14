using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G032 - .
/// </summary>
public class F40G032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDFRZID.
        /// </summary>
        public const string FDFRZID = "FDFRZID";

        /// <summary>
        /// FDTYPEHB.
        /// </summary>
        public const string FDTYPEHB = "FDTYPEHB";

        /// <summary>
        /// FDWVID.
        /// </summary>
        public const string FDWVID = "FDWVID";

        /// <summary>
        /// FDUPLNMAT.
        /// </summary>
        public const string FDUPLNMAT = "FDUPLNMAT";

        /// <summary>
        /// FDLNID.
        /// </summary>
        public const string FDLNID = "FDLNID";

        /// <summary>
        /// FDTYPEBF.
        /// </summary>
        public const string FDTYPEBF = "FDTYPEBF";

        /// <summary>
        /// FDEURID.
        /// </summary>
        public const string FDEURID = "FDEURID";

        /// <summary>
        /// FDEURPRTY.
        /// </summary>
        public const string FDEURPRTY = "FDEURPRTY";

        /// <summary>
        /// FDUCLCMAT.
        /// </summary>
        public const string FDUCLCMAT = "FDUCLCMAT";

        /// <summary>
        /// FDGEOCST.
        /// </summary>
        public const string FDGEOCST = "FDGEOCST";

        /// <summary>
        /// FDFRZNAME.
        /// </summary>
        public const string FDFRZNAME = "FDFRZNAME";

        /// <summary>
        /// FDFRZDT.
        /// </summary>
        public const string FDFRZDT = "FDFRZDT";

        /// <summary>
        /// FDEURSCD.
        /// </summary>
        public const string FDEURSCD = "FDEURSCD";

        /// <summary>
        /// FDEURFIXED.
        /// </summary>
        public const string FDEURFIXED = "FDEURFIXED";

        /// <summary>
        /// FDEURBAL.
        /// </summary>
        public const string FDEURBAL = "FDEURBAL";

        /// <summary>
        /// FDEURQTYX.
        /// </summary>
        public const string FDEURQTYX = "FDEURQTYX";

        /// <summary>
        /// FDUOM.
        /// </summary>
        public const string FDUOM = "FDUOM";

        /// <summary>
        /// FDSITEC.
        /// </summary>
        public const string FDSITEC = "FDSITEC";

        /// <summary>
        /// FDSITEP.
        /// </summary>
        public const string FDSITEP = "FDSITEP";

        /// <summary>
        /// FDFRZPRRC.
        /// </summary>
        public const string FDFRZPRRC = "FDFRZPRRC";

        /// <summary>
        /// FDCRCD.
        /// </summary>
        public const string FDCRCD = "FDCRCD";

        /// <summary>
        /// FDPLEV.
        /// </summary>
        public const string FDPLEV = "FDPLEV";

        /// <summary>
        /// FDCNTRTID.
        /// </summary>
        public const string FDCNTRTID = "FDCNTRTID";

        /// <summary>
        /// FDCNTRTDID.
        /// </summary>
        public const string FDCNTRTDID = "FDCNTRTDID";

        /// <summary>
        /// FDWOPRC.
        /// </summary>
        public const string FDWOPRC = "FDWOPRC";

        /// <summary>
        /// FDURCD.
        /// </summary>
        public const string FDURCD = "FDURCD";

        /// <summary>
        /// FDURDT.
        /// </summary>
        public const string FDURDT = "FDURDT";

        /// <summary>
        /// FDURRF.
        /// </summary>
        public const string FDURRF = "FDURRF";

        /// <summary>
        /// FDURAT.
        /// </summary>
        public const string FDURAT = "FDURAT";

        /// <summary>
        /// FDURAB.
        /// </summary>
        public const string FDURAB = "FDURAB";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDTORG.
        /// </summary>
        public const string FDTORG = "FDTORG";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUUPMJ.
        /// </summary>
        public const string FDUUPMJ = "FDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDFRZID", "FDFRZID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDTYPEHB", "FDTYPEHB", JdeDataType.String, 2, true, true),
        new JdeField("FDWVID", "FDWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDUPLNMAT", "FDUPLNMAT", JdeDataType.Date, null, true, true),
        new JdeField("FDLNID", "FDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDTYPEBF", "FDTYPEBF", JdeDataType.String, 2),
        new JdeField("FDEURID", "FDEURID", JdeDataType.Numeric),
        new JdeField("FDEURPRTY", "FDEURPRTY", JdeDataType.Numeric),
        new JdeField("FDUCLCMAT", "FDUCLCMAT", JdeDataType.Date),
        new JdeField("FDGEOCST", "FDGEOCST", JdeDataType.String, 6),
        new JdeField("FDFRZNAME", "FDFRZNAME", JdeDataType.String, 80),
        new JdeField("FDFRZDT", "FDFRZDT", JdeDataType.Date),
        new JdeField("FDEURSCD", "FDEURSCD", JdeDataType.String, 20),
        new JdeField("FDEURFIXED", "FDEURFIXED", JdeDataType.Numeric),
        new JdeField("FDEURBAL", "FDEURBAL", JdeDataType.Numeric),
        new JdeField("FDEURQTYX", "FDEURQTYX", JdeDataType.Numeric),
        new JdeField("FDUOM", "FDUOM", JdeDataType.String, 4),
        new JdeField("FDSITEC", "FDSITEC", JdeDataType.String, 24),
        new JdeField("FDSITEP", "FDSITEP", JdeDataType.String, 24),
        new JdeField("FDFRZPRRC", "FDFRZPRRC", JdeDataType.Numeric),
        new JdeField("FDCRCD", "FDCRCD", JdeDataType.String, 6),
        new JdeField("FDPLEV", "FDPLEV", JdeDataType.String, 2),
        new JdeField("FDCNTRTID", "FDCNTRTID", JdeDataType.Numeric),
        new JdeField("FDCNTRTDID", "FDCNTRTDID", JdeDataType.Numeric),
        new JdeField("FDWOPRC", "FDWOPRC", JdeDataType.String, 60),
        new JdeField("FDURCD", "FDURCD", JdeDataType.String, 4),
        new JdeField("FDURDT", "FDURDT", JdeDataType.Numeric),
        new JdeField("FDURRF", "FDURRF", JdeDataType.String, 30),
        new JdeField("FDURAT", "FDURAT", JdeDataType.Numeric),
        new JdeField("FDURAB", "FDURAB", JdeDataType.Numeric),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDTORG", "FDTORG", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUUPMJ", "FDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G032_0", "Primary Key on FDFRZID, FDTYPEHB, FDWVID, FDUPLNMAT, FDLNID", new[] { "FDFRZID", "FDTYPEHB", "FDWVID", "FDUPLNMAT", "FDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G032_2", "Index on FDWVID, FDFRZNAME, FDUPLNMAT, FDTYPEBF, FDEURPRTY, FDEURID, FDFRZID", new[] { "FDWVID", "FDFRZNAME", "FDUPLNMAT", "FDTYPEBF", "FDEURPRTY", "FDEURID", "FDFRZID" }),
        new JdeIndex("F40G032_3", "Index on FDFRZNAME", new[] { "FDFRZNAME" })
    };
}
