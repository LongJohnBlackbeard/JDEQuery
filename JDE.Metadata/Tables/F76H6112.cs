using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6112 - .
/// </summary>
public class F76H6112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ANDCT.
        /// </summary>
        public const string ANDCT = "ANDCT";

        /// <summary>
        /// ANFY.
        /// </summary>
        public const string ANFY = "ANFY";

        /// <summary>
        /// ANCTRY.
        /// </summary>
        public const string ANCTRY = "ANCTRY";

        /// <summary>
        /// ANITM.
        /// </summary>
        public const string ANITM = "ANITM";

        /// <summary>
        /// ANLITM.
        /// </summary>
        public const string ANLITM = "ANLITM";

        /// <summary>
        /// ANAITM.
        /// </summary>
        public const string ANAITM = "ANAITM";

        /// <summary>
        /// ANMCU.
        /// </summary>
        public const string ANMCU = "ANMCU";

        /// <summary>
        /// ANLOCN.
        /// </summary>
        public const string ANLOCN = "ANLOCN";

        /// <summary>
        /// ANLOTN.
        /// </summary>
        public const string ANLOTN = "ANLOTN";

        /// <summary>
        /// ANGLPT.
        /// </summary>
        public const string ANGLPT = "ANGLPT";

        /// <summary>
        /// ANNQ01.
        /// </summary>
        public const string ANNQ01 = "ANNQ01";

        /// <summary>
        /// ANNQ02.
        /// </summary>
        public const string ANNQ02 = "ANNQ02";

        /// <summary>
        /// ANNQ03.
        /// </summary>
        public const string ANNQ03 = "ANNQ03";

        /// <summary>
        /// ANNQ04.
        /// </summary>
        public const string ANNQ04 = "ANNQ04";

        /// <summary>
        /// ANNQ05.
        /// </summary>
        public const string ANNQ05 = "ANNQ05";

        /// <summary>
        /// ANNQ06.
        /// </summary>
        public const string ANNQ06 = "ANNQ06";

        /// <summary>
        /// ANNQ07.
        /// </summary>
        public const string ANNQ07 = "ANNQ07";

        /// <summary>
        /// ANNQ08.
        /// </summary>
        public const string ANNQ08 = "ANNQ08";

        /// <summary>
        /// ANNQ09.
        /// </summary>
        public const string ANNQ09 = "ANNQ09";

        /// <summary>
        /// ANNQ10.
        /// </summary>
        public const string ANNQ10 = "ANNQ10";

        /// <summary>
        /// ANNQ11.
        /// </summary>
        public const string ANNQ11 = "ANNQ11";

        /// <summary>
        /// ANNQ12.
        /// </summary>
        public const string ANNQ12 = "ANNQ12";

        /// <summary>
        /// ANNQ13.
        /// </summary>
        public const string ANNQ13 = "ANNQ13";

        /// <summary>
        /// ANNQ14.
        /// </summary>
        public const string ANNQ14 = "ANNQ14";

        /// <summary>
        /// ANAN01.
        /// </summary>
        public const string ANAN01 = "ANAN01";

        /// <summary>
        /// ANAN02.
        /// </summary>
        public const string ANAN02 = "ANAN02";

        /// <summary>
        /// ANAN03.
        /// </summary>
        public const string ANAN03 = "ANAN03";

        /// <summary>
        /// ANAN04.
        /// </summary>
        public const string ANAN04 = "ANAN04";

        /// <summary>
        /// ANAN05.
        /// </summary>
        public const string ANAN05 = "ANAN05";

        /// <summary>
        /// ANAN06.
        /// </summary>
        public const string ANAN06 = "ANAN06";

        /// <summary>
        /// ANAN07.
        /// </summary>
        public const string ANAN07 = "ANAN07";

        /// <summary>
        /// ANAN08.
        /// </summary>
        public const string ANAN08 = "ANAN08";

        /// <summary>
        /// ANAN09.
        /// </summary>
        public const string ANAN09 = "ANAN09";

        /// <summary>
        /// ANAN10.
        /// </summary>
        public const string ANAN10 = "ANAN10";

        /// <summary>
        /// ANAN11.
        /// </summary>
        public const string ANAN11 = "ANAN11";

        /// <summary>
        /// ANAN12.
        /// </summary>
        public const string ANAN12 = "ANAN12";

        /// <summary>
        /// ANAN13.
        /// </summary>
        public const string ANAN13 = "ANAN13";

        /// <summary>
        /// ANAN14.
        /// </summary>
        public const string ANAN14 = "ANAN14";

        /// <summary>
        /// ANCUMA.
        /// </summary>
        public const string ANCUMA = "ANCUMA";

        /// <summary>
        /// ANCMQT.
        /// </summary>
        public const string ANCMQT = "ANCMQT";

        /// <summary>
        /// ANAISL.
        /// </summary>
        public const string ANAISL = "ANAISL";

        /// <summary>
        /// ANBIN.
        /// </summary>
        public const string ANBIN = "ANBIN";

        /// <summary>
        /// ANTDAY.
        /// </summary>
        public const string ANTDAY = "ANTDAY";

        /// <summary>
        /// ANUSER.
        /// </summary>
        public const string ANUSER = "ANUSER";

        /// <summary>
        /// ANPID.
        /// </summary>
        public const string ANPID = "ANPID";

        /// <summary>
        /// ANUPMJ.
        /// </summary>
        public const string ANUPMJ = "ANUPMJ";

        /// <summary>
        /// ANJOBN.
        /// </summary>
        public const string ANJOBN = "ANJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ANDCT", "ANDCT", JdeDataType.String, 4, true, true),
        new JdeField("ANFY", "ANFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ANCTRY", "ANCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ANITM", "ANITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ANLITM", "ANLITM", JdeDataType.String, 50),
        new JdeField("ANAITM", "ANAITM", JdeDataType.String, 50),
        new JdeField("ANMCU", "ANMCU", JdeDataType.String, 24, true, true),
        new JdeField("ANLOCN", "ANLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ANLOTN", "ANLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ANGLPT", "ANGLPT", JdeDataType.String, 8, true, true),
        new JdeField("ANNQ01", "ANNQ01", JdeDataType.Numeric),
        new JdeField("ANNQ02", "ANNQ02", JdeDataType.Numeric),
        new JdeField("ANNQ03", "ANNQ03", JdeDataType.Numeric),
        new JdeField("ANNQ04", "ANNQ04", JdeDataType.Numeric),
        new JdeField("ANNQ05", "ANNQ05", JdeDataType.Numeric),
        new JdeField("ANNQ06", "ANNQ06", JdeDataType.Numeric),
        new JdeField("ANNQ07", "ANNQ07", JdeDataType.Numeric),
        new JdeField("ANNQ08", "ANNQ08", JdeDataType.Numeric),
        new JdeField("ANNQ09", "ANNQ09", JdeDataType.Numeric),
        new JdeField("ANNQ10", "ANNQ10", JdeDataType.Numeric),
        new JdeField("ANNQ11", "ANNQ11", JdeDataType.Numeric),
        new JdeField("ANNQ12", "ANNQ12", JdeDataType.Numeric),
        new JdeField("ANNQ13", "ANNQ13", JdeDataType.Numeric),
        new JdeField("ANNQ14", "ANNQ14", JdeDataType.Numeric),
        new JdeField("ANAN01", "ANAN01", JdeDataType.Numeric),
        new JdeField("ANAN02", "ANAN02", JdeDataType.Numeric),
        new JdeField("ANAN03", "ANAN03", JdeDataType.Numeric),
        new JdeField("ANAN04", "ANAN04", JdeDataType.Numeric),
        new JdeField("ANAN05", "ANAN05", JdeDataType.Numeric),
        new JdeField("ANAN06", "ANAN06", JdeDataType.Numeric),
        new JdeField("ANAN07", "ANAN07", JdeDataType.Numeric),
        new JdeField("ANAN08", "ANAN08", JdeDataType.Numeric),
        new JdeField("ANAN09", "ANAN09", JdeDataType.Numeric),
        new JdeField("ANAN10", "ANAN10", JdeDataType.Numeric),
        new JdeField("ANAN11", "ANAN11", JdeDataType.Numeric),
        new JdeField("ANAN12", "ANAN12", JdeDataType.Numeric),
        new JdeField("ANAN13", "ANAN13", JdeDataType.Numeric),
        new JdeField("ANAN14", "ANAN14", JdeDataType.Numeric),
        new JdeField("ANCUMA", "ANCUMA", JdeDataType.Numeric),
        new JdeField("ANCMQT", "ANCMQT", JdeDataType.Numeric),
        new JdeField("ANAISL", "ANAISL", JdeDataType.String, 16),
        new JdeField("ANBIN", "ANBIN", JdeDataType.String, 16),
        new JdeField("ANTDAY", "ANTDAY", JdeDataType.Numeric),
        new JdeField("ANUSER", "ANUSER", JdeDataType.String, 20),
        new JdeField("ANPID", "ANPID", JdeDataType.String, 20),
        new JdeField("ANUPMJ", "ANUPMJ", JdeDataType.Numeric),
        new JdeField("ANJOBN", "ANJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6112_0", "Primary Key on ANDCT, ANFY, ANCTRY, ANITM, ANMCU, ANLOCN, ANLOTN, ANGLPT", new[] { "ANDCT", "ANFY", "ANCTRY", "ANITM", "ANMCU", "ANLOCN", "ANLOTN", "ANGLPT" }, isUnique: true, isPrimaryKey: true)
    };
}
