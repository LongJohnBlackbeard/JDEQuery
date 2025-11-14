using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41UI002 - .
/// </summary>
public class F41UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TILNID.
        /// </summary>
        public const string TILNID = "TILNID";

        /// <summary>
        /// TIITM.
        /// </summary>
        public const string TIITM = "TIITM";

        /// <summary>
        /// TIMCU.
        /// </summary>
        public const string TIMCU = "TIMCU";

        /// <summary>
        /// TIPID.
        /// </summary>
        public const string TIPID = "TIPID";

        /// <summary>
        /// TITRQT.
        /// </summary>
        public const string TITRQT = "TITRQT";

        /// <summary>
        /// TITRUM.
        /// </summary>
        public const string TITRUM = "TITRUM";

        /// <summary>
        /// TILOCN.
        /// </summary>
        public const string TILOCN = "TILOCN";

        /// <summary>
        /// TILOTN.
        /// </summary>
        public const string TILOTN = "TILOTN";

        /// <summary>
        /// TIUNCS.
        /// </summary>
        public const string TIUNCS = "TIUNCS";

        /// <summary>
        /// TIPAID.
        /// </summary>
        public const string TIPAID = "TIPAID";

        /// <summary>
        /// TIDGL.
        /// </summary>
        public const string TIDGL = "TIDGL";

        /// <summary>
        /// TIRCD.
        /// </summary>
        public const string TIRCD = "TIRCD";

        /// <summary>
        /// TILOTG.
        /// </summary>
        public const string TILOTG = "TILOTG";

        /// <summary>
        /// TILOTP.
        /// </summary>
        public const string TILOTP = "TILOTP";

        /// <summary>
        /// TILOTS.
        /// </summary>
        public const string TILOTS = "TILOTS";

        /// <summary>
        /// TIMMEJ.
        /// </summary>
        public const string TIMMEJ = "TIMMEJ";

        /// <summary>
        /// TILDSC.
        /// </summary>
        public const string TILDSC = "TILDSC";

        /// <summary>
        /// TIUOM1.
        /// </summary>
        public const string TIUOM1 = "TIUOM1";

        /// <summary>
        /// TIPRRC.
        /// </summary>
        public const string TIPRRC = "TIPRRC";

        /// <summary>
        /// TIDOCO.
        /// </summary>
        public const string TIDOCO = "TIDOCO";

        /// <summary>
        /// TIDCTO.
        /// </summary>
        public const string TIDCTO = "TIDCTO";

        /// <summary>
        /// TIKCOO.
        /// </summary>
        public const string TIKCOO = "TIKCOO";

        /// <summary>
        /// TIEDSP.
        /// </summary>
        public const string TIEDSP = "TIEDSP";

        /// <summary>
        /// TILOTC.
        /// </summary>
        public const string TILOTC = "TILOTC";
    }

    /// <inheritdoc />
    public override string TableName => "F41UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TILNID", "TILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TIITM", "TIITM", JdeDataType.Numeric),
        new JdeField("TIMCU", "TIMCU", JdeDataType.String, 24),
        new JdeField("TIPID", "TIPID", JdeDataType.String, 20),
        new JdeField("TITRQT", "TITRQT", JdeDataType.Numeric),
        new JdeField("TITRUM", "TITRUM", JdeDataType.String, 4),
        new JdeField("TILOCN", "TILOCN", JdeDataType.String, 40),
        new JdeField("TILOTN", "TILOTN", JdeDataType.String, 60),
        new JdeField("TIUNCS", "TIUNCS", JdeDataType.Numeric),
        new JdeField("TIPAID", "TIPAID", JdeDataType.Numeric),
        new JdeField("TIDGL", "TIDGL", JdeDataType.Numeric),
        new JdeField("TIRCD", "TIRCD", JdeDataType.String, 6),
        new JdeField("TILOTG", "TILOTG", JdeDataType.String, 6),
        new JdeField("TILOTP", "TILOTP", JdeDataType.Numeric),
        new JdeField("TILOTS", "TILOTS", JdeDataType.String, 2),
        new JdeField("TIMMEJ", "TIMMEJ", JdeDataType.Numeric),
        new JdeField("TILDSC", "TILDSC", JdeDataType.String, 60),
        new JdeField("TIUOM1", "TIUOM1", JdeDataType.String, 4),
        new JdeField("TIPRRC", "TIPRRC", JdeDataType.Numeric),
        new JdeField("TIDOCO", "TIDOCO", JdeDataType.Numeric),
        new JdeField("TIDCTO", "TIDCTO", JdeDataType.String, 4),
        new JdeField("TIKCOO", "TIKCOO", JdeDataType.String, 10),
        new JdeField("TIEDSP", "TIEDSP", JdeDataType.String, 2),
        new JdeField("TILOTC", "TILOTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41UI002_0", "Primary Key on TILNID", new[] { "TILNID" }, isUnique: true, isPrimaryKey: true)
    };
}
