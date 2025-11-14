using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080436 - .
/// </summary>
public class F080436 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTSVER.
        /// </summary>
        public const string VTSVER = "VTSVER";

        /// <summary>
        /// VTACYV.
        /// </summary>
        public const string VTACYV = "VTACYV";

        /// <summary>
        /// VTTORO.
        /// </summary>
        public const string VTTORO = "VTTORO";

        /// <summary>
        /// VTTYOF.
        /// </summary>
        public const string VTTYOF = "VTTYOF";

        /// <summary>
        /// VTNMSC.
        /// </summary>
        public const string VTNMSC = "VTNMSC";

        /// <summary>
        /// VTTMEP.
        /// </summary>
        public const string VTTMEP = "VTTMEP";

        /// <summary>
        /// VTNMCY.
        /// </summary>
        public const string VTNMCY = "VTNMCY";

        /// <summary>
        /// VTAPC1.
        /// </summary>
        public const string VTAPC1 = "VTAPC1";

        /// <summary>
        /// VTAPC2.
        /// </summary>
        public const string VTAPC2 = "VTAPC2";

        /// <summary>
        /// VTCPTC.
        /// </summary>
        public const string VTCPTC = "VTCPTC";

        /// <summary>
        /// VTCNYP.
        /// </summary>
        public const string VTCNYP = "VTCNYP";

        /// <summary>
        /// VTSTYV.
        /// </summary>
        public const string VTSTYV = "VTSTYV";

        /// <summary>
        /// VTPCYV.
        /// </summary>
        public const string VTPCYV = "VTPCYV";

        /// <summary>
        /// VTNMPC.
        /// </summary>
        public const string VTNMPC = "VTNMPC";

        /// <summary>
        /// VTPHYV.
        /// </summary>
        public const string VTPHYV = "VTPHYV";

        /// <summary>
        /// VTEPCY.
        /// </summary>
        public const string VTEPCY = "VTEPCY";

        /// <summary>
        /// VTNAMH.
        /// </summary>
        public const string VTNAMH = "VTNAMH";

        /// <summary>
        /// VTAHL1.
        /// </summary>
        public const string VTAHL1 = "VTAHL1";

        /// <summary>
        /// VTAHL2.
        /// </summary>
        public const string VTAHL2 = "VTAHL2";

        /// <summary>
        /// VTCTHL.
        /// </summary>
        public const string VTCTHL = "VTCTHL";

        /// <summary>
        /// VTCYHL.
        /// </summary>
        public const string VTCYHL = "VTCYHL";

        /// <summary>
        /// VTSTHL.
        /// </summary>
        public const string VTSTHL = "VTSTHL";

        /// <summary>
        /// VTPCHL.
        /// </summary>
        public const string VTPCHL = "VTPCHL";

        /// <summary>
        /// VTNAIS.
        /// </summary>
        public const string VTNAIS = "VTNAIS";

        /// <summary>
        /// VTDUVT.
        /// </summary>
        public const string VTDUVT = "VTDUVT";

        /// <summary>
        /// VTEIDV.
        /// </summary>
        public const string VTEIDV = "VTEIDV";

        /// <summary>
        /// VTVTVV01.
        /// </summary>
        public const string VTVTVV01 = "VTVTVV01";

        /// <summary>
        /// VTVTVV02.
        /// </summary>
        public const string VTVTVV02 = "VTVTVV02";

        /// <summary>
        /// VTVTVV03.
        /// </summary>
        public const string VTVTVV03 = "VTVTVV03";

        /// <summary>
        /// VTVTVV04.
        /// </summary>
        public const string VTVTVV04 = "VTVTVV04";

        /// <summary>
        /// VTVTVV05.
        /// </summary>
        public const string VTVTVV05 = "VTVTVV05";

        /// <summary>
        /// VTVTVV06.
        /// </summary>
        public const string VTVTVV06 = "VTVTVV06";

        /// <summary>
        /// VTVTVV07.
        /// </summary>
        public const string VTVTVV07 = "VTVTVV07";

        /// <summary>
        /// VTVTVV08.
        /// </summary>
        public const string VTVTVV08 = "VTVTVV08";

        /// <summary>
        /// VTVTVV09.
        /// </summary>
        public const string VTVTVV09 = "VTVTVV09";

        /// <summary>
        /// VTVTVV10.
        /// </summary>
        public const string VTVTVV10 = "VTVTVV10";

        /// <summary>
        /// VTVTVV11.
        /// </summary>
        public const string VTVTVV11 = "VTVTVV11";

        /// <summary>
        /// VTVTVV12.
        /// </summary>
        public const string VTVTVV12 = "VTVTVV12";

        /// <summary>
        /// VTVTVV13.
        /// </summary>
        public const string VTVTVV13 = "VTVTVV13";

        /// <summary>
        /// VTVTVV14.
        /// </summary>
        public const string VTVTVV14 = "VTVTVV14";

        /// <summary>
        /// VTVTVV15.
        /// </summary>
        public const string VTVTVV15 = "VTVTVV15";

        /// <summary>
        /// VTVTVV16.
        /// </summary>
        public const string VTVTVV16 = "VTVTVV16";

        /// <summary>
        /// VTVTVV17.
        /// </summary>
        public const string VTVTVV17 = "VTVTVV17";

        /// <summary>
        /// VTVTVV18.
        /// </summary>
        public const string VTVTVV18 = "VTVTVV18";

        /// <summary>
        /// VTVTVV19.
        /// </summary>
        public const string VTVTVV19 = "VTVTVV19";

        /// <summary>
        /// VTVTVV20.
        /// </summary>
        public const string VTVTVV20 = "VTVTVV20";

        /// <summary>
        /// VTVTVV21.
        /// </summary>
        public const string VTVTVV21 = "VTVTVV21";

        /// <summary>
        /// VTVTVV22.
        /// </summary>
        public const string VTVTVV22 = "VTVTVV22";

        /// <summary>
        /// VTVTVV23.
        /// </summary>
        public const string VTVTVV23 = "VTVTVV23";

        /// <summary>
        /// VTVTVV24.
        /// </summary>
        public const string VTVTVV24 = "VTVTVV24";

        /// <summary>
        /// VTVTVV25.
        /// </summary>
        public const string VTVTVV25 = "VTVTVV25";

        /// <summary>
        /// VTVTVV26.
        /// </summary>
        public const string VTVTVV26 = "VTVTVV26";

        /// <summary>
        /// VTVTVV27.
        /// </summary>
        public const string VTVTVV27 = "VTVTVV27";

        /// <summary>
        /// VTVTVV28.
        /// </summary>
        public const string VTVTVV28 = "VTVTVV28";

        /// <summary>
        /// VTVTVV29.
        /// </summary>
        public const string VTVTVV29 = "VTVTVV29";

        /// <summary>
        /// VTVTVV30.
        /// </summary>
        public const string VTVTVV30 = "VTVTVV30";

        /// <summary>
        /// VTVTVV31.
        /// </summary>
        public const string VTVTVV31 = "VTVTVV31";

        /// <summary>
        /// VTVTVV32.
        /// </summary>
        public const string VTVTVV32 = "VTVTVV32";

        /// <summary>
        /// VTVTVV33.
        /// </summary>
        public const string VTVTVV33 = "VTVTVV33";

        /// <summary>
        /// VTVTVV34.
        /// </summary>
        public const string VTVTVV34 = "VTVTVV34";

        /// <summary>
        /// VTVTVV35.
        /// </summary>
        public const string VTVTVV35 = "VTVTVV35";

        /// <summary>
        /// VTVTVV36.
        /// </summary>
        public const string VTVTVV36 = "VTVTVV36";

        /// <summary>
        /// VTVTVV37.
        /// </summary>
        public const string VTVTVV37 = "VTVTVV37";

        /// <summary>
        /// VTVTVV38.
        /// </summary>
        public const string VTVTVV38 = "VTVTVV38";

        /// <summary>
        /// VTVTVV39.
        /// </summary>
        public const string VTVTVV39 = "VTVTVV39";

        /// <summary>
        /// VTVTVV40.
        /// </summary>
        public const string VTVTVV40 = "VTVTVV40";

        /// <summary>
        /// VTVTVV41.
        /// </summary>
        public const string VTVTVV41 = "VTVTVV41";

        /// <summary>
        /// VTVTVV42.
        /// </summary>
        public const string VTVTVV42 = "VTVTVV42";

        /// <summary>
        /// VTVTVV43.
        /// </summary>
        public const string VTVTVV43 = "VTVTVV43";

        /// <summary>
        /// VTVTVV44.
        /// </summary>
        public const string VTVTVV44 = "VTVTVV44";

        /// <summary>
        /// VTVTVVMX.
        /// </summary>
        public const string VTVTVVMX = "VTVTVVMX";

        /// <summary>
        /// VTVTVVMN.
        /// </summary>
        public const string VTVTVVMN = "VTVTVVMN";
    }

    /// <inheritdoc />
    public override string TableName => "F080436";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTSVER", "VTSVER", JdeDataType.String, 20, true, true),
        new JdeField("VTACYV", "VTACYV", JdeDataType.String, 14, true, true),
        new JdeField("VTTORO", "VTTORO", JdeDataType.String, 2),
        new JdeField("VTTYOF", "VTTYOF", JdeDataType.String, 6),
        new JdeField("VTNMSC", "VTNMSC", JdeDataType.String, 16),
        new JdeField("VTTMEP", "VTTMEP", JdeDataType.String, 20, true, true),
        new JdeField("VTNMCY", "VTNMCY", JdeDataType.String, 200),
        new JdeField("VTAPC1", "VTAPC1", JdeDataType.String, 200),
        new JdeField("VTAPC2", "VTAPC2", JdeDataType.String, 200),
        new JdeField("VTCPTC", "VTCPTC", JdeDataType.String, 100),
        new JdeField("VTCNYP", "VTCNYP", JdeDataType.String, 100),
        new JdeField("VTSTYV", "VTSTYV", JdeDataType.String, 4),
        new JdeField("VTPCYV", "VTPCYV", JdeDataType.String, 18),
        new JdeField("VTNMPC", "VTNMPC", JdeDataType.String, 200),
        new JdeField("VTPHYV", "VTPHYV", JdeDataType.String, 40),
        new JdeField("VTEPCY", "VTEPCY", JdeDataType.String, 200),
        new JdeField("VTNAMH", "VTNAMH", JdeDataType.String, 200, true, true),
        new JdeField("VTAHL1", "VTAHL1", JdeDataType.String, 200),
        new JdeField("VTAHL2", "VTAHL2", JdeDataType.String, 200),
        new JdeField("VTCTHL", "VTCTHL", JdeDataType.String, 100),
        new JdeField("VTCYHL", "VTCYHL", JdeDataType.String, 100),
        new JdeField("VTSTHL", "VTSTHL", JdeDataType.String, 4),
        new JdeField("VTPCHL", "VTPCHL", JdeDataType.String, 18),
        new JdeField("VTNAIS", "VTNAIS", JdeDataType.String, 12),
        new JdeField("VTDUVT", "VTDUVT", JdeDataType.String, 18),
        new JdeField("VTEIDV", "VTEIDV", JdeDataType.String, 18),
        new JdeField("VTVTVV01", "VTVTVV01", JdeDataType.Numeric),
        new JdeField("VTVTVV02", "VTVTVV02", JdeDataType.Numeric),
        new JdeField("VTVTVV03", "VTVTVV03", JdeDataType.Numeric),
        new JdeField("VTVTVV04", "VTVTVV04", JdeDataType.Numeric),
        new JdeField("VTVTVV05", "VTVTVV05", JdeDataType.Numeric),
        new JdeField("VTVTVV06", "VTVTVV06", JdeDataType.Numeric),
        new JdeField("VTVTVV07", "VTVTVV07", JdeDataType.Numeric),
        new JdeField("VTVTVV08", "VTVTVV08", JdeDataType.Numeric),
        new JdeField("VTVTVV09", "VTVTVV09", JdeDataType.Numeric),
        new JdeField("VTVTVV10", "VTVTVV10", JdeDataType.Numeric),
        new JdeField("VTVTVV11", "VTVTVV11", JdeDataType.Numeric),
        new JdeField("VTVTVV12", "VTVTVV12", JdeDataType.Numeric),
        new JdeField("VTVTVV13", "VTVTVV13", JdeDataType.Numeric),
        new JdeField("VTVTVV14", "VTVTVV14", JdeDataType.Numeric),
        new JdeField("VTVTVV15", "VTVTVV15", JdeDataType.Numeric),
        new JdeField("VTVTVV16", "VTVTVV16", JdeDataType.Numeric),
        new JdeField("VTVTVV17", "VTVTVV17", JdeDataType.Numeric),
        new JdeField("VTVTVV18", "VTVTVV18", JdeDataType.Numeric),
        new JdeField("VTVTVV19", "VTVTVV19", JdeDataType.Numeric),
        new JdeField("VTVTVV20", "VTVTVV20", JdeDataType.Numeric),
        new JdeField("VTVTVV21", "VTVTVV21", JdeDataType.Numeric),
        new JdeField("VTVTVV22", "VTVTVV22", JdeDataType.Numeric),
        new JdeField("VTVTVV23", "VTVTVV23", JdeDataType.Numeric),
        new JdeField("VTVTVV24", "VTVTVV24", JdeDataType.Numeric),
        new JdeField("VTVTVV25", "VTVTVV25", JdeDataType.Numeric),
        new JdeField("VTVTVV26", "VTVTVV26", JdeDataType.Numeric),
        new JdeField("VTVTVV27", "VTVTVV27", JdeDataType.Numeric),
        new JdeField("VTVTVV28", "VTVTVV28", JdeDataType.Numeric),
        new JdeField("VTVTVV29", "VTVTVV29", JdeDataType.Numeric),
        new JdeField("VTVTVV30", "VTVTVV30", JdeDataType.Numeric),
        new JdeField("VTVTVV31", "VTVTVV31", JdeDataType.Numeric),
        new JdeField("VTVTVV32", "VTVTVV32", JdeDataType.Numeric),
        new JdeField("VTVTVV33", "VTVTVV33", JdeDataType.Numeric),
        new JdeField("VTVTVV34", "VTVTVV34", JdeDataType.Numeric),
        new JdeField("VTVTVV35", "VTVTVV35", JdeDataType.Numeric),
        new JdeField("VTVTVV36", "VTVTVV36", JdeDataType.Numeric),
        new JdeField("VTVTVV37", "VTVTVV37", JdeDataType.Numeric),
        new JdeField("VTVTVV38", "VTVTVV38", JdeDataType.Numeric),
        new JdeField("VTVTVV39", "VTVTVV39", JdeDataType.Numeric),
        new JdeField("VTVTVV40", "VTVTVV40", JdeDataType.Numeric),
        new JdeField("VTVTVV41", "VTVTVV41", JdeDataType.Numeric),
        new JdeField("VTVTVV42", "VTVTVV42", JdeDataType.Numeric),
        new JdeField("VTVTVV43", "VTVTVV43", JdeDataType.Numeric),
        new JdeField("VTVTVV44", "VTVTVV44", JdeDataType.Numeric),
        new JdeField("VTVTVVMX", "VTVTVVMX", JdeDataType.Numeric),
        new JdeField("VTVTVVMN", "VTVTVVMN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080436_0", "Primary Key on VTSVER, VTACYV, VTTMEP, VTNAMH", new[] { "VTSVER", "VTACYV", "VTTMEP", "VTNAMH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F080436_2", "Index on VTSVER, VTACYV, VTTMEP, VTNMCY", new[] { "VTSVER", "VTACYV", "VTTMEP", "VTNMCY" })
    };
}
