using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3450 - .
/// </summary>
public class F3450 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAMCU.
        /// </summary>
        public const string MAMCU = "MAMCU";

        /// <summary>
        /// MAITM.
        /// </summary>
        public const string MAITM = "MAITM";

        /// <summary>
        /// MAAN8.
        /// </summary>
        public const string MAAN8 = "MAAN8";

        /// <summary>
        /// MASTRT.
        /// </summary>
        public const string MASTRT = "MASTRT";

        /// <summary>
        /// MAMEAS.
        /// </summary>
        public const string MAMEAS = "MAMEAS";

        /// <summary>
        /// MAPLQT.
        /// </summary>
        public const string MAPLQT = "MAPLQT";

        /// <summary>
        /// MACMQTY.
        /// </summary>
        public const string MACMQTY = "MACMQTY";

        /// <summary>
        /// MARLQT.
        /// </summary>
        public const string MARLQT = "MARLQT";

        /// <summary>
        /// MAEDDT.
        /// </summary>
        public const string MAEDDT = "MAEDDT";

        /// <summary>
        /// MAGENQJ.
        /// </summary>
        public const string MAGENQJ = "MAGENQJ";

        /// <summary>
        /// MAVENQJ.
        /// </summary>
        public const string MAVENQJ = "MAVENQJ";

        /// <summary>
        /// MAALNC.
        /// </summary>
        public const string MAALNC = "MAALNC";

        /// <summary>
        /// MAALSH.
        /// </summary>
        public const string MAALSH = "MAALSH";

        /// <summary>
        /// MADOCO.
        /// </summary>
        public const string MADOCO = "MADOCO";

        /// <summary>
        /// MADCTO.
        /// </summary>
        public const string MADCTO = "MADCTO";

        /// <summary>
        /// MAKCOO.
        /// </summary>
        public const string MAKCOO = "MAKCOO";

        /// <summary>
        /// MASFXO.
        /// </summary>
        public const string MASFXO = "MASFXO";

        /// <summary>
        /// MALNID.
        /// </summary>
        public const string MALNID = "MALNID";

        /// <summary>
        /// MAURC1.
        /// </summary>
        public const string MAURC1 = "MAURC1";

        /// <summary>
        /// MAURDT.
        /// </summary>
        public const string MAURDT = "MAURDT";

        /// <summary>
        /// MAURAB.
        /// </summary>
        public const string MAURAB = "MAURAB";

        /// <summary>
        /// MAURAT.
        /// </summary>
        public const string MAURAT = "MAURAT";

        /// <summary>
        /// MAURRF.
        /// </summary>
        public const string MAURRF = "MAURRF";

        /// <summary>
        /// MAUSER.
        /// </summary>
        public const string MAUSER = "MAUSER";

        /// <summary>
        /// MAPID.
        /// </summary>
        public const string MAPID = "MAPID";

        /// <summary>
        /// MAWRKSTNID.
        /// </summary>
        public const string MAWRKSTNID = "MAWRKSTNID";

        /// <summary>
        /// MAUPMJ.
        /// </summary>
        public const string MAUPMJ = "MAUPMJ";

        /// <summary>
        /// MATDAY.
        /// </summary>
        public const string MATDAY = "MATDAY";

        /// <summary>
        /// MAPMPN.
        /// </summary>
        public const string MAPMPN = "MAPMPN";

        /// <summary>
        /// MAPNS.
        /// </summary>
        public const string MAPNS = "MAPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3450";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAMCU", "MAMCU", JdeDataType.String, 24, true, true),
        new JdeField("MAITM", "MAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MAAN8", "MAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MASTRT", "MASTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("MAMEAS", "MAMEAS", JdeDataType.String, 2, true, true),
        new JdeField("MAPLQT", "MAPLQT", JdeDataType.Numeric),
        new JdeField("MACMQTY", "MACMQTY", JdeDataType.Numeric),
        new JdeField("MARLQT", "MARLQT", JdeDataType.Numeric),
        new JdeField("MAEDDT", "MAEDDT", JdeDataType.Numeric),
        new JdeField("MAGENQJ", "MAGENQJ", JdeDataType.Numeric),
        new JdeField("MAVENQJ", "MAVENQJ", JdeDataType.Numeric),
        new JdeField("MAALNC", "MAALNC", JdeDataType.String, 2),
        new JdeField("MAALSH", "MAALSH", JdeDataType.String, 2),
        new JdeField("MADOCO", "MADOCO", JdeDataType.Numeric),
        new JdeField("MADCTO", "MADCTO", JdeDataType.String, 4),
        new JdeField("MAKCOO", "MAKCOO", JdeDataType.String, 10),
        new JdeField("MASFXO", "MASFXO", JdeDataType.String, 6),
        new JdeField("MALNID", "MALNID", JdeDataType.Numeric),
        new JdeField("MAURC1", "MAURC1", JdeDataType.String, 6),
        new JdeField("MAURDT", "MAURDT", JdeDataType.Numeric),
        new JdeField("MAURAB", "MAURAB", JdeDataType.Numeric),
        new JdeField("MAURAT", "MAURAT", JdeDataType.Numeric),
        new JdeField("MAURRF", "MAURRF", JdeDataType.String, 30),
        new JdeField("MAUSER", "MAUSER", JdeDataType.String, 20),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAWRKSTNID", "MAWRKSTNID", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MATDAY", "MATDAY", JdeDataType.Numeric),
        new JdeField("MAPMPN", "MAPMPN", JdeDataType.String, 60),
        new JdeField("MAPNS", "MAPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3450_0", "Primary Key on MAMCU, MAITM, MAAN8, MASTRT, MAMEAS", new[] { "MAMCU", "MAITM", "MAAN8", "MASTRT", "MAMEAS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3450_2", "Index on MAMCU, MAAN8, MAITM, MASTRT, MAMEAS", new[] { "MAMCU", "MAAN8", "MAITM", "MASTRT", "MAMEAS" })
    };
}
