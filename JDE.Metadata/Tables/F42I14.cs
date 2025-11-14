using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I14 - .
/// </summary>
public class F42I14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMSCHJBTYP.
        /// </summary>
        public const string OMSCHJBTYP = "OMSCHJBTYP";

        /// <summary>
        /// OMOIMFJBNM.
        /// </summary>
        public const string OMOIMFJBNM = "OMOIMFJBNM";

        /// <summary>
        /// OMDL01.
        /// </summary>
        public const string OMDL01 = "OMDL01";

        /// <summary>
        /// OMPROCNAME.
        /// </summary>
        public const string OMPROCNAME = "OMPROCNAME";

        /// <summary>
        /// OMSCHSTTIME.
        /// </summary>
        public const string OMSCHSTTIME = "OMSCHSTTIME";

        /// <summary>
        /// OMSCHENTIME.
        /// </summary>
        public const string OMSCHENTIME = "OMSCHENTIME";

        /// <summary>
        /// OMNUMJOBOCC.
        /// </summary>
        public const string OMNUMJOBOCC = "OMNUMJOBOCC";

        /// <summary>
        /// OMCURRUNCNT.
        /// </summary>
        public const string OMCURRUNCNT = "OMCURRUNCNT";

        /// <summary>
        /// OMSCHJBSTAT.
        /// </summary>
        public const string OMSCHJBSTAT = "OMSCHJBSTAT";

        /// <summary>
        /// OMSCHRCRTYP.
        /// </summary>
        public const string OMSCHRCRTYP = "OMSCHRCRTYP";

        /// <summary>
        /// OMCO.
        /// </summary>
        public const string OMCO = "OMCO";

        /// <summary>
        /// OMSCHNUMMNS.
        /// </summary>
        public const string OMSCHNUMMNS = "OMSCHNUMMNS";

        /// <summary>
        /// OMSCHNUMHRS.
        /// </summary>
        public const string OMSCHNUMHRS = "OMSCHNUMHRS";

        /// <summary>
        /// OMSCHNUMDY.
        /// </summary>
        public const string OMSCHNUMDY = "OMSCHNUMDY";

        /// <summary>
        /// OMSCHNUMWKS.
        /// </summary>
        public const string OMSCHNUMWKS = "OMSCHNUMWKS";

        /// <summary>
        /// OMSCHNUMMN.
        /// </summary>
        public const string OMSCHNUMMN = "OMSCHNUMMN";

        /// <summary>
        /// OMSCHDAY.
        /// </summary>
        public const string OMSCHDAY = "OMSCHDAY";

        /// <summary>
        /// OMWEEKDAY.
        /// </summary>
        public const string OMWEEKDAY = "OMWEEKDAY";

        /// <summary>
        /// OMWEEKEND.
        /// </summary>
        public const string OMWEEKEND = "OMWEEKEND";

        /// <summary>
        /// OMMONDAY.
        /// </summary>
        public const string OMMONDAY = "OMMONDAY";

        /// <summary>
        /// OMTUESDAY.
        /// </summary>
        public const string OMTUESDAY = "OMTUESDAY";

        /// <summary>
        /// OMWEDNESDAY.
        /// </summary>
        public const string OMWEDNESDAY = "OMWEDNESDAY";

        /// <summary>
        /// OMTHURSDAY.
        /// </summary>
        public const string OMTHURSDAY = "OMTHURSDAY";

        /// <summary>
        /// OMFRIDAY.
        /// </summary>
        public const string OMFRIDAY = "OMFRIDAY";

        /// <summary>
        /// OMSATURDAY.
        /// </summary>
        public const string OMSATURDAY = "OMSATURDAY";

        /// <summary>
        /// OMSUNDAY.
        /// </summary>
        public const string OMSUNDAY = "OMSUNDAY";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMJOBN.
        /// </summary>
        public const string OMJOBN = "OMJOBN";

        /// <summary>
        /// OMUPMJ.
        /// </summary>
        public const string OMUPMJ = "OMUPMJ";

        /// <summary>
        /// OMUPMT.
        /// </summary>
        public const string OMUPMT = "OMUPMT";

        /// <summary>
        /// OMURAT.
        /// </summary>
        public const string OMURAT = "OMURAT";

        /// <summary>
        /// OMURCD.
        /// </summary>
        public const string OMURCD = "OMURCD";

        /// <summary>
        /// OMURDT.
        /// </summary>
        public const string OMURDT = "OMURDT";

        /// <summary>
        /// OMURAB.
        /// </summary>
        public const string OMURAB = "OMURAB";

        /// <summary>
        /// OMURRF.
        /// </summary>
        public const string OMURRF = "OMURRF";

        /// <summary>
        /// OMFUCHAR64.
        /// </summary>
        public const string OMFUCHAR64 = "OMFUCHAR64";

        /// <summary>
        /// OMFUCHAR65.
        /// </summary>
        public const string OMFUCHAR65 = "OMFUCHAR65";

        /// <summary>
        /// OMFUCHAR66.
        /// </summary>
        public const string OMFUCHAR66 = "OMFUCHAR66";

        /// <summary>
        /// OMFUNUM64.
        /// </summary>
        public const string OMFUNUM64 = "OMFUNUM64";

        /// <summary>
        /// OMFUNUM65.
        /// </summary>
        public const string OMFUNUM65 = "OMFUNUM65";

        /// <summary>
        /// OMFUNUM66.
        /// </summary>
        public const string OMFUNUM66 = "OMFUNUM66";

        /// <summary>
        /// OMFSTR64.
        /// </summary>
        public const string OMFSTR64 = "OMFSTR64";

        /// <summary>
        /// OMFSTR65.
        /// </summary>
        public const string OMFSTR65 = "OMFSTR65";

        /// <summary>
        /// OMFSTR66.
        /// </summary>
        public const string OMFSTR66 = "OMFSTR66";

        /// <summary>
        /// OMFUDT64.
        /// </summary>
        public const string OMFUDT64 = "OMFUDT64";

        /// <summary>
        /// OMFUDT65.
        /// </summary>
        public const string OMFUDT65 = "OMFUDT65";

        /// <summary>
        /// OMFUDT66.
        /// </summary>
        public const string OMFUDT66 = "OMFUDT66";
    }

    /// <inheritdoc />
    public override string TableName => "F42I14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMSCHJBTYP", "OMSCHJBTYP", JdeDataType.String, 4),
        new JdeField("OMOIMFJBNM", "OMOIMFJBNM", JdeDataType.String, 60, true, true),
        new JdeField("OMDL01", "OMDL01", JdeDataType.String, 60),
        new JdeField("OMPROCNAME", "OMPROCNAME", JdeDataType.String, 20),
        new JdeField("OMSCHSTTIME", "OMSCHSTTIME", JdeDataType.Numeric),
        new JdeField("OMSCHENTIME", "OMSCHENTIME", JdeDataType.Numeric),
        new JdeField("OMNUMJOBOCC", "OMNUMJOBOCC", JdeDataType.Numeric),
        new JdeField("OMCURRUNCNT", "OMCURRUNCNT", JdeDataType.Numeric),
        new JdeField("OMSCHJBSTAT", "OMSCHJBSTAT", JdeDataType.String, 4),
        new JdeField("OMSCHRCRTYP", "OMSCHRCRTYP", JdeDataType.String, 4),
        new JdeField("OMCO", "OMCO", JdeDataType.String, 10),
        new JdeField("OMSCHNUMMNS", "OMSCHNUMMNS", JdeDataType.Numeric),
        new JdeField("OMSCHNUMHRS", "OMSCHNUMHRS", JdeDataType.Numeric),
        new JdeField("OMSCHNUMDY", "OMSCHNUMDY", JdeDataType.Numeric),
        new JdeField("OMSCHNUMWKS", "OMSCHNUMWKS", JdeDataType.Numeric),
        new JdeField("OMSCHNUMMN", "OMSCHNUMMN", JdeDataType.Numeric),
        new JdeField("OMSCHDAY", "OMSCHDAY", JdeDataType.String, 2),
        new JdeField("OMWEEKDAY", "OMWEEKDAY", JdeDataType.String, 2),
        new JdeField("OMWEEKEND", "OMWEEKEND", JdeDataType.String, 2),
        new JdeField("OMMONDAY", "OMMONDAY", JdeDataType.String, 2),
        new JdeField("OMTUESDAY", "OMTUESDAY", JdeDataType.String, 2),
        new JdeField("OMWEDNESDAY", "OMWEDNESDAY", JdeDataType.String, 2),
        new JdeField("OMTHURSDAY", "OMTHURSDAY", JdeDataType.String, 2),
        new JdeField("OMFRIDAY", "OMFRIDAY", JdeDataType.String, 2),
        new JdeField("OMSATURDAY", "OMSATURDAY", JdeDataType.String, 2),
        new JdeField("OMSUNDAY", "OMSUNDAY", JdeDataType.String, 2),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMJOBN", "OMJOBN", JdeDataType.String, 20),
        new JdeField("OMUPMJ", "OMUPMJ", JdeDataType.Numeric),
        new JdeField("OMUPMT", "OMUPMT", JdeDataType.Numeric),
        new JdeField("OMURAT", "OMURAT", JdeDataType.Numeric),
        new JdeField("OMURCD", "OMURCD", JdeDataType.String, 4),
        new JdeField("OMURDT", "OMURDT", JdeDataType.Numeric),
        new JdeField("OMURAB", "OMURAB", JdeDataType.Numeric),
        new JdeField("OMURRF", "OMURRF", JdeDataType.String, 30),
        new JdeField("OMFUCHAR64", "OMFUCHAR64", JdeDataType.String, 2),
        new JdeField("OMFUCHAR65", "OMFUCHAR65", JdeDataType.String, 2),
        new JdeField("OMFUCHAR66", "OMFUCHAR66", JdeDataType.String, 2),
        new JdeField("OMFUNUM64", "OMFUNUM64", JdeDataType.Numeric),
        new JdeField("OMFUNUM65", "OMFUNUM65", JdeDataType.Numeric),
        new JdeField("OMFUNUM66", "OMFUNUM66", JdeDataType.Numeric),
        new JdeField("OMFSTR64", "OMFSTR64", JdeDataType.String, 100),
        new JdeField("OMFSTR65", "OMFSTR65", JdeDataType.String, 100),
        new JdeField("OMFSTR66", "OMFSTR66", JdeDataType.String, 100),
        new JdeField("OMFUDT64", "OMFUDT64", JdeDataType.Numeric),
        new JdeField("OMFUDT65", "OMFUDT65", JdeDataType.Numeric),
        new JdeField("OMFUDT66", "OMFUDT66", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I14_0", "Primary Key on OMOIMFJBNM", new[] { "OMOIMFJBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
