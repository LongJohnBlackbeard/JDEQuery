using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I05 - .
/// </summary>
public class F42I05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OISHAN.
        /// </summary>
        public const string OISHAN = "OISHAN";

        /// <summary>
        /// OILITM.
        /// </summary>
        public const string OILITM = "OILITM";

        /// <summary>
        /// OIITM.
        /// </summary>
        public const string OIITM = "OIITM";

        /// <summary>
        /// OILOCN.
        /// </summary>
        public const string OILOCN = "OILOCN";

        /// <summary>
        /// OIOLTY.
        /// </summary>
        public const string OIOLTY = "OIOLTY";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OITDAY.
        /// </summary>
        public const string OITDAY = "OITDAY";

        /// <summary>
        /// OIFUCHAR19.
        /// </summary>
        public const string OIFUCHAR19 = "OIFUCHAR19";

        /// <summary>
        /// OIFUCHAR20.
        /// </summary>
        public const string OIFUCHAR20 = "OIFUCHAR20";

        /// <summary>
        /// OIFUCHAR21.
        /// </summary>
        public const string OIFUCHAR21 = "OIFUCHAR21";

        /// <summary>
        /// OIFUNUM19.
        /// </summary>
        public const string OIFUNUM19 = "OIFUNUM19";

        /// <summary>
        /// OIFUNUM20.
        /// </summary>
        public const string OIFUNUM20 = "OIFUNUM20";

        /// <summary>
        /// OIFUNUM21.
        /// </summary>
        public const string OIFUNUM21 = "OIFUNUM21";

        /// <summary>
        /// OIFUTSTR19.
        /// </summary>
        public const string OIFUTSTR19 = "OIFUTSTR19";

        /// <summary>
        /// OIFUTSTR20.
        /// </summary>
        public const string OIFUTSTR20 = "OIFUTSTR20";

        /// <summary>
        /// OIFUTSTR21.
        /// </summary>
        public const string OIFUTSTR21 = "OIFUTSTR21";

        /// <summary>
        /// OIFUDT8.
        /// </summary>
        public const string OIFUDT8 = "OIFUDT8";

        /// <summary>
        /// OIFUDT12.
        /// </summary>
        public const string OIFUDT12 = "OIFUDT12";

        /// <summary>
        /// OIFUDT22.
        /// </summary>
        public const string OIFUDT22 = "OIFUDT22";
    }

    /// <inheritdoc />
    public override string TableName => "F42I05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24, true, true),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OISHAN", "OISHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OILOCN", "OILOCN", JdeDataType.String, 40),
        new JdeField("OIOLTY", "OIOLTY", JdeDataType.String, 6, true, true),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OIFUCHAR19", "OIFUCHAR19", JdeDataType.String, 2),
        new JdeField("OIFUCHAR20", "OIFUCHAR20", JdeDataType.String, 2),
        new JdeField("OIFUCHAR21", "OIFUCHAR21", JdeDataType.String, 2),
        new JdeField("OIFUNUM19", "OIFUNUM19", JdeDataType.Numeric),
        new JdeField("OIFUNUM20", "OIFUNUM20", JdeDataType.Numeric),
        new JdeField("OIFUNUM21", "OIFUNUM21", JdeDataType.Numeric),
        new JdeField("OIFUTSTR19", "OIFUTSTR19", JdeDataType.String, 100),
        new JdeField("OIFUTSTR20", "OIFUTSTR20", JdeDataType.String, 100),
        new JdeField("OIFUTSTR21", "OIFUTSTR21", JdeDataType.String, 100),
        new JdeField("OIFUDT8", "OIFUDT8", JdeDataType.Numeric),
        new JdeField("OIFUDT12", "OIFUDT12", JdeDataType.Numeric),
        new JdeField("OIFUDT22", "OIFUDT22", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I05_0", "Primary Key on OIMCU, OIOLTY, OIAN8, OISHAN, OIITM", new[] { "OIMCU", "OIOLTY", "OIAN8", "OISHAN", "OIITM" }, isUnique: true, isPrimaryKey: true)
    };
}
