using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1404 - .
/// </summary>
public class F1404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BYMCU.
        /// </summary>
        public const string BYMCU = "BYMCU";

        /// <summary>
        /// BYAID.
        /// </summary>
        public const string BYAID = "BYAID";

        /// <summary>
        /// BYRVNUM.
        /// </summary>
        public const string BYRVNUM = "BYRVNUM";

        /// <summary>
        /// BYDL01.
        /// </summary>
        public const string BYDL01 = "BYDL01";

        /// <summary>
        /// BYOBJ.
        /// </summary>
        public const string BYOBJ = "BYOBJ";

        /// <summary>
        /// BYSUB.
        /// </summary>
        public const string BYSUB = "BYSUB";

        /// <summary>
        /// BYCO.
        /// </summary>
        public const string BYCO = "BYCO";

        /// <summary>
        /// BYFY01.
        /// </summary>
        public const string BYFY01 = "BYFY01";

        /// <summary>
        /// BYCTRY01.
        /// </summary>
        public const string BYCTRY01 = "BYCTRY01";

        /// <summary>
        /// BYFA01.
        /// </summary>
        public const string BYFA01 = "BYFA01";

        /// <summary>
        /// BYFY02.
        /// </summary>
        public const string BYFY02 = "BYFY02";

        /// <summary>
        /// BYCTRY02.
        /// </summary>
        public const string BYCTRY02 = "BYCTRY02";

        /// <summary>
        /// BYFA02.
        /// </summary>
        public const string BYFA02 = "BYFA02";

        /// <summary>
        /// BYFY03.
        /// </summary>
        public const string BYFY03 = "BYFY03";

        /// <summary>
        /// BYCTRY03.
        /// </summary>
        public const string BYCTRY03 = "BYCTRY03";

        /// <summary>
        /// BYFA03.
        /// </summary>
        public const string BYFA03 = "BYFA03";

        /// <summary>
        /// BYFY04.
        /// </summary>
        public const string BYFY04 = "BYFY04";

        /// <summary>
        /// BYCTRY04.
        /// </summary>
        public const string BYCTRY04 = "BYCTRY04";

        /// <summary>
        /// BYFA04.
        /// </summary>
        public const string BYFA04 = "BYFA04";

        /// <summary>
        /// BYFY05.
        /// </summary>
        public const string BYFY05 = "BYFY05";

        /// <summary>
        /// BYCTRY05.
        /// </summary>
        public const string BYCTRY05 = "BYCTRY05";

        /// <summary>
        /// BYFA05.
        /// </summary>
        public const string BYFA05 = "BYFA05";

        /// <summary>
        /// BYFY06.
        /// </summary>
        public const string BYFY06 = "BYFY06";

        /// <summary>
        /// BYCTRY06.
        /// </summary>
        public const string BYCTRY06 = "BYCTRY06";

        /// <summary>
        /// BYFA06.
        /// </summary>
        public const string BYFA06 = "BYFA06";

        /// <summary>
        /// BYFY07.
        /// </summary>
        public const string BYFY07 = "BYFY07";

        /// <summary>
        /// BYCTRY07.
        /// </summary>
        public const string BYCTRY07 = "BYCTRY07";

        /// <summary>
        /// BYFA07.
        /// </summary>
        public const string BYFA07 = "BYFA07";

        /// <summary>
        /// BYFY08.
        /// </summary>
        public const string BYFY08 = "BYFY08";

        /// <summary>
        /// BYCTRY08.
        /// </summary>
        public const string BYCTRY08 = "BYCTRY08";

        /// <summary>
        /// BYFA08.
        /// </summary>
        public const string BYFA08 = "BYFA08";

        /// <summary>
        /// BYFY09.
        /// </summary>
        public const string BYFY09 = "BYFY09";

        /// <summary>
        /// BYCTRY09.
        /// </summary>
        public const string BYCTRY09 = "BYCTRY09";

        /// <summary>
        /// BYFA09.
        /// </summary>
        public const string BYFA09 = "BYFA09";

        /// <summary>
        /// BYFY10.
        /// </summary>
        public const string BYFY10 = "BYFY10";

        /// <summary>
        /// BYCTRY10.
        /// </summary>
        public const string BYCTRY10 = "BYCTRY10";

        /// <summary>
        /// BYFA10.
        /// </summary>
        public const string BYFA10 = "BYFA10";

        /// <summary>
        /// BYFY11.
        /// </summary>
        public const string BYFY11 = "BYFY11";

        /// <summary>
        /// BYCTRY11.
        /// </summary>
        public const string BYCTRY11 = "BYCTRY11";

        /// <summary>
        /// BYFA11.
        /// </summary>
        public const string BYFA11 = "BYFA11";

        /// <summary>
        /// BYFY12.
        /// </summary>
        public const string BYFY12 = "BYFY12";

        /// <summary>
        /// BYCTRY12.
        /// </summary>
        public const string BYCTRY12 = "BYCTRY12";

        /// <summary>
        /// BYFA12.
        /// </summary>
        public const string BYFA12 = "BYFA12";

        /// <summary>
        /// BYFY13.
        /// </summary>
        public const string BYFY13 = "BYFY13";

        /// <summary>
        /// BYCTRY13.
        /// </summary>
        public const string BYCTRY13 = "BYCTRY13";

        /// <summary>
        /// BYFA13.
        /// </summary>
        public const string BYFA13 = "BYFA13";

        /// <summary>
        /// BYFY14.
        /// </summary>
        public const string BYFY14 = "BYFY14";

        /// <summary>
        /// BYCTRY14.
        /// </summary>
        public const string BYCTRY14 = "BYCTRY14";

        /// <summary>
        /// BYFA14.
        /// </summary>
        public const string BYFA14 = "BYFA14";

        /// <summary>
        /// BYFY15.
        /// </summary>
        public const string BYFY15 = "BYFY15";

        /// <summary>
        /// BYCTRY15.
        /// </summary>
        public const string BYCTRY15 = "BYCTRY15";

        /// <summary>
        /// BYFA15.
        /// </summary>
        public const string BYFA15 = "BYFA15";

        /// <summary>
        /// BYLOCKFLG.
        /// </summary>
        public const string BYLOCKFLG = "BYLOCKFLG";

        /// <summary>
        /// BYUSER.
        /// </summary>
        public const string BYUSER = "BYUSER";

        /// <summary>
        /// BYPID.
        /// </summary>
        public const string BYPID = "BYPID";

        /// <summary>
        /// BYJOBN.
        /// </summary>
        public const string BYJOBN = "BYJOBN";

        /// <summary>
        /// BYUPMJ.
        /// </summary>
        public const string BYUPMJ = "BYUPMJ";

        /// <summary>
        /// BYUPMT.
        /// </summary>
        public const string BYUPMT = "BYUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BYMCU", "BYMCU", JdeDataType.String, 24, true, true),
        new JdeField("BYAID", "BYAID", JdeDataType.String, 16, true, true),
        new JdeField("BYRVNUM", "BYRVNUM", JdeDataType.String, 20, true, true),
        new JdeField("BYDL01", "BYDL01", JdeDataType.String, 60),
        new JdeField("BYOBJ", "BYOBJ", JdeDataType.String, 12),
        new JdeField("BYSUB", "BYSUB", JdeDataType.String, 16),
        new JdeField("BYCO", "BYCO", JdeDataType.String, 10),
        new JdeField("BYFY01", "BYFY01", JdeDataType.Numeric),
        new JdeField("BYCTRY01", "BYCTRY01", JdeDataType.Numeric),
        new JdeField("BYFA01", "BYFA01", JdeDataType.Numeric),
        new JdeField("BYFY02", "BYFY02", JdeDataType.Numeric),
        new JdeField("BYCTRY02", "BYCTRY02", JdeDataType.Numeric),
        new JdeField("BYFA02", "BYFA02", JdeDataType.Numeric),
        new JdeField("BYFY03", "BYFY03", JdeDataType.Numeric),
        new JdeField("BYCTRY03", "BYCTRY03", JdeDataType.Numeric),
        new JdeField("BYFA03", "BYFA03", JdeDataType.Numeric),
        new JdeField("BYFY04", "BYFY04", JdeDataType.Numeric),
        new JdeField("BYCTRY04", "BYCTRY04", JdeDataType.Numeric),
        new JdeField("BYFA04", "BYFA04", JdeDataType.Numeric),
        new JdeField("BYFY05", "BYFY05", JdeDataType.Numeric),
        new JdeField("BYCTRY05", "BYCTRY05", JdeDataType.Numeric),
        new JdeField("BYFA05", "BYFA05", JdeDataType.Numeric),
        new JdeField("BYFY06", "BYFY06", JdeDataType.Numeric),
        new JdeField("BYCTRY06", "BYCTRY06", JdeDataType.Numeric),
        new JdeField("BYFA06", "BYFA06", JdeDataType.Numeric),
        new JdeField("BYFY07", "BYFY07", JdeDataType.Numeric),
        new JdeField("BYCTRY07", "BYCTRY07", JdeDataType.Numeric),
        new JdeField("BYFA07", "BYFA07", JdeDataType.Numeric),
        new JdeField("BYFY08", "BYFY08", JdeDataType.Numeric),
        new JdeField("BYCTRY08", "BYCTRY08", JdeDataType.Numeric),
        new JdeField("BYFA08", "BYFA08", JdeDataType.Numeric),
        new JdeField("BYFY09", "BYFY09", JdeDataType.Numeric),
        new JdeField("BYCTRY09", "BYCTRY09", JdeDataType.Numeric),
        new JdeField("BYFA09", "BYFA09", JdeDataType.Numeric),
        new JdeField("BYFY10", "BYFY10", JdeDataType.Numeric),
        new JdeField("BYCTRY10", "BYCTRY10", JdeDataType.Numeric),
        new JdeField("BYFA10", "BYFA10", JdeDataType.Numeric),
        new JdeField("BYFY11", "BYFY11", JdeDataType.Numeric),
        new JdeField("BYCTRY11", "BYCTRY11", JdeDataType.Numeric),
        new JdeField("BYFA11", "BYFA11", JdeDataType.Numeric),
        new JdeField("BYFY12", "BYFY12", JdeDataType.Numeric),
        new JdeField("BYCTRY12", "BYCTRY12", JdeDataType.Numeric),
        new JdeField("BYFA12", "BYFA12", JdeDataType.Numeric),
        new JdeField("BYFY13", "BYFY13", JdeDataType.Numeric),
        new JdeField("BYCTRY13", "BYCTRY13", JdeDataType.Numeric),
        new JdeField("BYFA13", "BYFA13", JdeDataType.Numeric),
        new JdeField("BYFY14", "BYFY14", JdeDataType.Numeric),
        new JdeField("BYCTRY14", "BYCTRY14", JdeDataType.Numeric),
        new JdeField("BYFA14", "BYFA14", JdeDataType.Numeric),
        new JdeField("BYFY15", "BYFY15", JdeDataType.Numeric),
        new JdeField("BYCTRY15", "BYCTRY15", JdeDataType.Numeric),
        new JdeField("BYFA15", "BYFA15", JdeDataType.Numeric),
        new JdeField("BYLOCKFLG", "BYLOCKFLG", JdeDataType.String, 2),
        new JdeField("BYUSER", "BYUSER", JdeDataType.String, 20),
        new JdeField("BYPID", "BYPID", JdeDataType.String, 20),
        new JdeField("BYJOBN", "BYJOBN", JdeDataType.String, 20),
        new JdeField("BYUPMJ", "BYUPMJ", JdeDataType.Numeric),
        new JdeField("BYUPMT", "BYUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1404_0", "Primary Key on BYMCU, BYAID, BYRVNUM", new[] { "BYMCU", "BYAID", "BYRVNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1404_2", "Index on BYCO, BYMCU, BYRVNUM, BYOBJ, BYSUB", new[] { "BYCO", "BYMCU", "BYRVNUM", "BYOBJ", "BYSUB" })
    };
}
