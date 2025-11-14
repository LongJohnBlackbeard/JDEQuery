using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1510 - .
/// </summary>
public class F1510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OECO.
        /// </summary>
        public const string OECO = "OECO";

        /// <summary>
        /// OEMCU.
        /// </summary>
        public const string OEMCU = "OEMCU";

        /// <summary>
        /// OEICRR.
        /// </summary>
        public const string OEICRR = "OEICRR";

        /// <summary>
        /// OEIARR.
        /// </summary>
        public const string OEIARR = "OEIARR";

        /// <summary>
        /// OELYBM.
        /// </summary>
        public const string OELYBM = "OELYBM";

        /// <summary>
        /// OERYBM.
        /// </summary>
        public const string OERYBM = "OERYBM";

        /// <summary>
        /// OERMLC.
        /// </summary>
        public const string OERMLC = "OERMLC";

        /// <summary>
        /// OERMAI.
        /// </summary>
        public const string OERMAI = "OERMAI";

        /// <summary>
        /// OEUMLC.
        /// </summary>
        public const string OEUMLC = "OEUMLC";

        /// <summary>
        /// OEUMAI.
        /// </summary>
        public const string OEUMAI = "OEUMAI";

        /// <summary>
        /// OERFLC.
        /// </summary>
        public const string OERFLC = "OERFLC";

        /// <summary>
        /// OERFAI.
        /// </summary>
        public const string OERFAI = "OERFAI";

        /// <summary>
        /// OEUFLC.
        /// </summary>
        public const string OEUFLC = "OEUFLC";

        /// <summary>
        /// OEUFAI.
        /// </summary>
        public const string OEUFAI = "OEUFAI";

        /// <summary>
        /// OERULC.
        /// </summary>
        public const string OERULC = "OERULC";

        /// <summary>
        /// OERUAI.
        /// </summary>
        public const string OERUAI = "OERUAI";

        /// <summary>
        /// OEUULC.
        /// </summary>
        public const string OEUULC = "OEUULC";

        /// <summary>
        /// OEUUAI.
        /// </summary>
        public const string OEUUAI = "OEUUAI";

        /// <summary>
        /// OEDBAC.
        /// </summary>
        public const string OEDBAC = "OEDBAC";

        /// <summary>
        /// OERCCF.
        /// </summary>
        public const string OERCCF = "OERCCF";

        /// <summary>
        /// OEICBC.
        /// </summary>
        public const string OEICBC = "OEICBC";

        /// <summary>
        /// OEFG01.
        /// </summary>
        public const string OEFG01 = "OEFG01";

        /// <summary>
        /// OEFG02.
        /// </summary>
        public const string OEFG02 = "OEFG02";

        /// <summary>
        /// OEFG03.
        /// </summary>
        public const string OEFG03 = "OEFG03";

        /// <summary>
        /// OEFG04.
        /// </summary>
        public const string OEFG04 = "OEFG04";

        /// <summary>
        /// OEFG05.
        /// </summary>
        public const string OEFG05 = "OEFG05";

        /// <summary>
        /// OEFG06.
        /// </summary>
        public const string OEFG06 = "OEFG06";

        /// <summary>
        /// OEFG07.
        /// </summary>
        public const string OEFG07 = "OEFG07";

        /// <summary>
        /// OEFG08.
        /// </summary>
        public const string OEFG08 = "OEFG08";

        /// <summary>
        /// OEFG09.
        /// </summary>
        public const string OEFG09 = "OEFG09";

        /// <summary>
        /// OEFG10.
        /// </summary>
        public const string OEFG10 = "OEFG10";

        /// <summary>
        /// OEUSER.
        /// </summary>
        public const string OEUSER = "OEUSER";

        /// <summary>
        /// OEPID.
        /// </summary>
        public const string OEPID = "OEPID";

        /// <summary>
        /// OEUPMJ.
        /// </summary>
        public const string OEUPMJ = "OEUPMJ";

        /// <summary>
        /// OEJOBN.
        /// </summary>
        public const string OEJOBN = "OEJOBN";

        /// <summary>
        /// OEUPMT.
        /// </summary>
        public const string OEUPMT = "OEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OECO", "OECO", JdeDataType.String, 10, true, true),
        new JdeField("OEMCU", "OEMCU", JdeDataType.String, 24, true, true),
        new JdeField("OEICRR", "OEICRR", JdeDataType.String, 2),
        new JdeField("OEIARR", "OEIARR", JdeDataType.String, 2),
        new JdeField("OELYBM", "OELYBM", JdeDataType.Numeric),
        new JdeField("OERYBM", "OERYBM", JdeDataType.Numeric),
        new JdeField("OERMLC", "OERMLC", JdeDataType.String, 4),
        new JdeField("OERMAI", "OERMAI", JdeDataType.String, 8),
        new JdeField("OEUMLC", "OEUMLC", JdeDataType.String, 4),
        new JdeField("OEUMAI", "OEUMAI", JdeDataType.String, 8),
        new JdeField("OERFLC", "OERFLC", JdeDataType.String, 4),
        new JdeField("OERFAI", "OERFAI", JdeDataType.String, 8),
        new JdeField("OEUFLC", "OEUFLC", JdeDataType.String, 4),
        new JdeField("OEUFAI", "OEUFAI", JdeDataType.String, 8),
        new JdeField("OERULC", "OERULC", JdeDataType.String, 4),
        new JdeField("OERUAI", "OERUAI", JdeDataType.String, 8),
        new JdeField("OEUULC", "OEUULC", JdeDataType.String, 4),
        new JdeField("OEUUAI", "OEUUAI", JdeDataType.String, 8),
        new JdeField("OEDBAC", "OEDBAC", JdeDataType.String, 2),
        new JdeField("OERCCF", "OERCCF", JdeDataType.String, 2),
        new JdeField("OEICBC", "OEICBC", JdeDataType.String, 4),
        new JdeField("OEFG01", "OEFG01", JdeDataType.String, 2),
        new JdeField("OEFG02", "OEFG02", JdeDataType.String, 2),
        new JdeField("OEFG03", "OEFG03", JdeDataType.String, 2),
        new JdeField("OEFG04", "OEFG04", JdeDataType.String, 2),
        new JdeField("OEFG05", "OEFG05", JdeDataType.String, 2),
        new JdeField("OEFG06", "OEFG06", JdeDataType.String, 2),
        new JdeField("OEFG07", "OEFG07", JdeDataType.String, 2),
        new JdeField("OEFG08", "OEFG08", JdeDataType.String, 2),
        new JdeField("OEFG09", "OEFG09", JdeDataType.String, 2),
        new JdeField("OEFG10", "OEFG10", JdeDataType.String, 2),
        new JdeField("OEUSER", "OEUSER", JdeDataType.String, 20),
        new JdeField("OEPID", "OEPID", JdeDataType.String, 20),
        new JdeField("OEUPMJ", "OEUPMJ", JdeDataType.Numeric),
        new JdeField("OEJOBN", "OEJOBN", JdeDataType.String, 20),
        new JdeField("OEUPMT", "OEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1510_0", "Primary Key on OECO, OEMCU", new[] { "OECO", "OEMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
