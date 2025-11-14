using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q40 - .
/// </summary>
public class F43Q40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAEVNU.
        /// </summary>
        public const string RAEVNU = "RAEVNU";

        /// <summary>
        /// RADCTO.
        /// </summary>
        public const string RADCTO = "RADCTO";

        /// <summary>
        /// RAKCOO.
        /// </summary>
        public const string RAKCOO = "RAKCOO";

        /// <summary>
        /// RABIDNUM.
        /// </summary>
        public const string RABIDNUM = "RABIDNUM";

        /// <summary>
        /// RAAN8.
        /// </summary>
        public const string RAAN8 = "RAAN8";

        /// <summary>
        /// RAMCU.
        /// </summary>
        public const string RAMCU = "RAMCU";

        /// <summary>
        /// RAEVFT.
        /// </summary>
        public const string RAEVFT = "RAEVFT";

        /// <summary>
        /// RABSTS01.
        /// </summary>
        public const string RABSTS01 = "RABSTS01";

        /// <summary>
        /// RACRDC.
        /// </summary>
        public const string RACRDC = "RACRDC";

        /// <summary>
        /// RACRCD.
        /// </summary>
        public const string RACRCD = "RACRCD";

        /// <summary>
        /// RACRR.
        /// </summary>
        public const string RACRR = "RACRR";

        /// <summary>
        /// RAFEDX.
        /// </summary>
        public const string RAFEDX = "RAFEDX";

        /// <summary>
        /// RADTETLS.
        /// </summary>
        public const string RADTETLS = "RADTETLS";

        /// <summary>
        /// RADTETP.
        /// </summary>
        public const string RADTETP = "RADTETP";

        /// <summary>
        /// RAHBQS.
        /// </summary>
        public const string RAHBQS = "RAHBQS";

        /// <summary>
        /// RATLBQS.
        /// </summary>
        public const string RATLBQS = "RATLBQS";

        /// <summary>
        /// RAMLNM.
        /// </summary>
        public const string RAMLNM = "RAMLNM";

        /// <summary>
        /// RAALPH.
        /// </summary>
        public const string RAALPH = "RAALPH";

        /// <summary>
        /// RAURCD.
        /// </summary>
        public const string RAURCD = "RAURCD";

        /// <summary>
        /// RAURDT.
        /// </summary>
        public const string RAURDT = "RAURDT";

        /// <summary>
        /// RAURAT.
        /// </summary>
        public const string RAURAT = "RAURAT";

        /// <summary>
        /// RAURAB.
        /// </summary>
        public const string RAURAB = "RAURAB";

        /// <summary>
        /// RAURRF.
        /// </summary>
        public const string RAURRF = "RAURRF";

        /// <summary>
        /// RATORG.
        /// </summary>
        public const string RATORG = "RATORG";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RATDAY.
        /// </summary>
        public const string RATDAY = "RATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAEVNU", "RAEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RADCTO", "RADCTO", JdeDataType.String, 4, true, true),
        new JdeField("RAKCOO", "RAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RABIDNUM", "RABIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RAAN8", "RAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RAMCU", "RAMCU", JdeDataType.String, 24),
        new JdeField("RAEVFT", "RAEVFT", JdeDataType.String, 6),
        new JdeField("RABSTS01", "RABSTS01", JdeDataType.String, 4),
        new JdeField("RACRDC", "RACRDC", JdeDataType.String, 6),
        new JdeField("RACRCD", "RACRCD", JdeDataType.String, 6),
        new JdeField("RACRR", "RACRR", JdeDataType.Numeric),
        new JdeField("RAFEDX", "RAFEDX", JdeDataType.Date),
        new JdeField("RADTETLS", "RADTETLS", JdeDataType.Date),
        new JdeField("RADTETP", "RADTETP", JdeDataType.Date),
        new JdeField("RAHBQS", "RAHBQS", JdeDataType.Numeric),
        new JdeField("RATLBQS", "RATLBQS", JdeDataType.Numeric),
        new JdeField("RAMLNM", "RAMLNM", JdeDataType.String, 80),
        new JdeField("RAALPH", "RAALPH", JdeDataType.String, 80),
        new JdeField("RAURCD", "RAURCD", JdeDataType.String, 4),
        new JdeField("RAURDT", "RAURDT", JdeDataType.Numeric),
        new JdeField("RAURAT", "RAURAT", JdeDataType.Numeric),
        new JdeField("RAURAB", "RAURAB", JdeDataType.Numeric),
        new JdeField("RAURRF", "RAURRF", JdeDataType.String, 30),
        new JdeField("RATORG", "RATORG", JdeDataType.String, 20),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RATDAY", "RATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q40_0", "Primary Key on RADCTO, RAEVNU, RAKCOO, RABIDNUM, RAAN8", new[] { "RADCTO", "RAEVNU", "RAKCOO", "RABIDNUM", "RAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q40_2", "Index on RAEVNU, RADCTO, RAKCOO, RAAN8", new[] { "RAEVNU", "RADCTO", "RAKCOO", "RAAN8" })
    };
}
