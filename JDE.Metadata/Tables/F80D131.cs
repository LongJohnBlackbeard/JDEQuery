using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D131 - .
/// </summary>
public class F80D131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CIALERTDET.
        /// </summary>
        public const string CIALERTDET = "CIALERTDET";

        /// <summary>
        /// CIFCDTAI.
        /// </summary>
        public const string CIFCDTAI = "CIFCDTAI";

        /// <summary>
        /// CIBSV.
        /// </summary>
        public const string CIBSV = "CIBSV";

        /// <summary>
        /// CIBMV.
        /// </summary>
        public const string CIBMV = "CIBMV";

        /// <summary>
        /// CIBDV.
        /// </summary>
        public const string CIBDV = "CIBDV";

        /// <summary>
        /// CIASV.
        /// </summary>
        public const string CIASV = "CIASV";

        /// <summary>
        /// CIAMV.
        /// </summary>
        public const string CIAMV = "CIAMV";

        /// <summary>
        /// CIADVALUE.
        /// </summary>
        public const string CIADVALUE = "CIADVALUE";

        /// <summary>
        /// CIKEY1S.
        /// </summary>
        public const string CIKEY1S = "CIKEY1S";

        /// <summary>
        /// CIKEY1N.
        /// </summary>
        public const string CIKEY1N = "CIKEY1N";

        /// <summary>
        /// CIKEY1D.
        /// </summary>
        public const string CIKEY1D = "CIKEY1D";

        /// <summary>
        /// CIKEY2S.
        /// </summary>
        public const string CIKEY2S = "CIKEY2S";

        /// <summary>
        /// CIKEY2N.
        /// </summary>
        public const string CIKEY2N = "CIKEY2N";

        /// <summary>
        /// CIKEY2D.
        /// </summary>
        public const string CIKEY2D = "CIKEY2D";

        /// <summary>
        /// CIKEY3S.
        /// </summary>
        public const string CIKEY3S = "CIKEY3S";

        /// <summary>
        /// CIKEY3N.
        /// </summary>
        public const string CIKEY3N = "CIKEY3N";

        /// <summary>
        /// CIKEY3D.
        /// </summary>
        public const string CIKEY3D = "CIKEY3D";

        /// <summary>
        /// CIKEY4S.
        /// </summary>
        public const string CIKEY4S = "CIKEY4S";

        /// <summary>
        /// CIKEY4N.
        /// </summary>
        public const string CIKEY4N = "CIKEY4N";

        /// <summary>
        /// CIKEY4D.
        /// </summary>
        public const string CIKEY4D = "CIKEY4D";

        /// <summary>
        /// CIKEY5S.
        /// </summary>
        public const string CIKEY5S = "CIKEY5S";

        /// <summary>
        /// CIKEY5N.
        /// </summary>
        public const string CIKEY5N = "CIKEY5N";

        /// <summary>
        /// CIKEY5D.
        /// </summary>
        public const string CIKEY5D = "CIKEY5D";

        /// <summary>
        /// CIKEY6S.
        /// </summary>
        public const string CIKEY6S = "CIKEY6S";

        /// <summary>
        /// CIKEY6N.
        /// </summary>
        public const string CIKEY6N = "CIKEY6N";

        /// <summary>
        /// CIKEY6D.
        /// </summary>
        public const string CIKEY6D = "CIKEY6D";

        /// <summary>
        /// CIKEY7S.
        /// </summary>
        public const string CIKEY7S = "CIKEY7S";

        /// <summary>
        /// CIKEY7N.
        /// </summary>
        public const string CIKEY7N = "CIKEY7N";

        /// <summary>
        /// CIKEY7D.
        /// </summary>
        public const string CIKEY7D = "CIKEY7D";

        /// <summary>
        /// CIKEY8S.
        /// </summary>
        public const string CIKEY8S = "CIKEY8S";

        /// <summary>
        /// CIKEY8N.
        /// </summary>
        public const string CIKEY8N = "CIKEY8N";

        /// <summary>
        /// CIKEY8D.
        /// </summary>
        public const string CIKEY8D = "CIKEY8D";

        /// <summary>
        /// CIKEY9S.
        /// </summary>
        public const string CIKEY9S = "CIKEY9S";

        /// <summary>
        /// CIKEY9N.
        /// </summary>
        public const string CIKEY9N = "CIKEY9N";

        /// <summary>
        /// CIKEY9D.
        /// </summary>
        public const string CIKEY9D = "CIKEY9D";

        /// <summary>
        /// CIKEY10S.
        /// </summary>
        public const string CIKEY10S = "CIKEY10S";

        /// <summary>
        /// CIKEY10N.
        /// </summary>
        public const string CIKEY10N = "CIKEY10N";

        /// <summary>
        /// CIKEY10D.
        /// </summary>
        public const string CIKEY10D = "CIKEY10D";

        /// <summary>
        /// CIURCD.
        /// </summary>
        public const string CIURCD = "CIURCD";

        /// <summary>
        /// CIURDT.
        /// </summary>
        public const string CIURDT = "CIURDT";

        /// <summary>
        /// CIURAT.
        /// </summary>
        public const string CIURAT = "CIURAT";

        /// <summary>
        /// CIURAB.
        /// </summary>
        public const string CIURAB = "CIURAB";

        /// <summary>
        /// CIURRF.
        /// </summary>
        public const string CIURRF = "CIURRF";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIMKEY.
        /// </summary>
        public const string CIMKEY = "CIMKEY";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIUUPMJ.
        /// </summary>
        public const string CIUUPMJ = "CIUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CIALERTDET", "CIALERTDET", JdeDataType.Numeric, null, true, true),
        new JdeField("CIFCDTAI", "CIFCDTAI", JdeDataType.String, 20),
        new JdeField("CIBSV", "CIBSV", JdeDataType.String, 160),
        new JdeField("CIBMV", "CIBMV", JdeDataType.Numeric),
        new JdeField("CIBDV", "CIBDV", JdeDataType.Numeric),
        new JdeField("CIASV", "CIASV", JdeDataType.String, 160),
        new JdeField("CIAMV", "CIAMV", JdeDataType.Numeric),
        new JdeField("CIADVALUE", "CIADVALUE", JdeDataType.Numeric),
        new JdeField("CIKEY1S", "CIKEY1S", JdeDataType.String, 160),
        new JdeField("CIKEY1N", "CIKEY1N", JdeDataType.Numeric),
        new JdeField("CIKEY1D", "CIKEY1D", JdeDataType.Numeric),
        new JdeField("CIKEY2S", "CIKEY2S", JdeDataType.String, 160),
        new JdeField("CIKEY2N", "CIKEY2N", JdeDataType.Numeric),
        new JdeField("CIKEY2D", "CIKEY2D", JdeDataType.Numeric),
        new JdeField("CIKEY3S", "CIKEY3S", JdeDataType.String, 160),
        new JdeField("CIKEY3N", "CIKEY3N", JdeDataType.Numeric),
        new JdeField("CIKEY3D", "CIKEY3D", JdeDataType.Numeric),
        new JdeField("CIKEY4S", "CIKEY4S", JdeDataType.String, 160),
        new JdeField("CIKEY4N", "CIKEY4N", JdeDataType.Numeric),
        new JdeField("CIKEY4D", "CIKEY4D", JdeDataType.Numeric),
        new JdeField("CIKEY5S", "CIKEY5S", JdeDataType.String, 160),
        new JdeField("CIKEY5N", "CIKEY5N", JdeDataType.Numeric),
        new JdeField("CIKEY5D", "CIKEY5D", JdeDataType.Numeric),
        new JdeField("CIKEY6S", "CIKEY6S", JdeDataType.String, 160),
        new JdeField("CIKEY6N", "CIKEY6N", JdeDataType.Numeric),
        new JdeField("CIKEY6D", "CIKEY6D", JdeDataType.Numeric),
        new JdeField("CIKEY7S", "CIKEY7S", JdeDataType.String, 160),
        new JdeField("CIKEY7N", "CIKEY7N", JdeDataType.Numeric),
        new JdeField("CIKEY7D", "CIKEY7D", JdeDataType.Numeric),
        new JdeField("CIKEY8S", "CIKEY8S", JdeDataType.String, 160),
        new JdeField("CIKEY8N", "CIKEY8N", JdeDataType.Numeric),
        new JdeField("CIKEY8D", "CIKEY8D", JdeDataType.Numeric),
        new JdeField("CIKEY9S", "CIKEY9S", JdeDataType.String, 160),
        new JdeField("CIKEY9N", "CIKEY9N", JdeDataType.Numeric),
        new JdeField("CIKEY9D", "CIKEY9D", JdeDataType.Numeric),
        new JdeField("CIKEY10S", "CIKEY10S", JdeDataType.String, 160),
        new JdeField("CIKEY10N", "CIKEY10N", JdeDataType.Numeric),
        new JdeField("CIKEY10D", "CIKEY10D", JdeDataType.Numeric),
        new JdeField("CIURCD", "CIURCD", JdeDataType.String, 4),
        new JdeField("CIURDT", "CIURDT", JdeDataType.Numeric),
        new JdeField("CIURAT", "CIURAT", JdeDataType.Numeric),
        new JdeField("CIURAB", "CIURAB", JdeDataType.Numeric),
        new JdeField("CIURRF", "CIURRF", JdeDataType.String, 30),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIMKEY", "CIMKEY", JdeDataType.String, 30),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIUUPMJ", "CIUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D131_0", "Primary Key on CIALERTDET", new[] { "CIALERTDET" }, isUnique: true, isPrimaryKey: true)
    };
}
