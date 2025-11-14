using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42A011 - .
/// </summary>
public class F42A011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACANM.
        /// </summary>
        public const string CACANM = "CACANM";

        /// <summary>
        /// CACADE.
        /// </summary>
        public const string CACADE = "CACADE";

        /// <summary>
        /// CATPCA.
        /// </summary>
        public const string CATPCA = "CATPCA";

        /// <summary>
        /// CASDCA.
        /// </summary>
        public const string CASDCA = "CASDCA";

        /// <summary>
        /// CAEDCA.
        /// </summary>
        public const string CAEDCA = "CAEDCA";

        /// <summary>
        /// CATERI.
        /// </summary>
        public const string CATERI = "CATERI";

        /// <summary>
        /// CACHTY.
        /// </summary>
        public const string CACHTY = "CACHTY";

        /// <summary>
        /// CACRCD.
        /// </summary>
        public const string CACRCD = "CACRCD";

        /// <summary>
        /// CACTGT.
        /// </summary>
        public const string CACTGT = "CACTGT";

        /// <summary>
        /// CACACU.
        /// </summary>
        public const string CACACU = "CACACU";

        /// <summary>
        /// CARTGT.
        /// </summary>
        public const string CARTGT = "CARTGT";

        /// <summary>
        /// CACRSP.
        /// </summary>
        public const string CACRSP = "CACRSP";

        /// <summary>
        /// CACRNS.
        /// </summary>
        public const string CACRNS = "CACRNS";

        /// <summary>
        /// CACARQ.
        /// </summary>
        public const string CACARQ = "CACARQ";

        /// <summary>
        /// CALBGT.
        /// </summary>
        public const string CALBGT = "CALBGT";

        /// <summary>
        /// CALACT.
        /// </summary>
        public const string CALACT = "CALACT";

        /// <summary>
        /// CAQLBU.
        /// </summary>
        public const string CAQLBU = "CAQLBU";

        /// <summary>
        /// CAQLAT.
        /// </summary>
        public const string CAQLAT = "CAQLAT";

        /// <summary>
        /// CAOMC1.
        /// </summary>
        public const string CAOMC1 = "CAOMC1";

        /// <summary>
        /// CAOMC2.
        /// </summary>
        public const string CAOMC2 = "CAOMC2";

        /// <summary>
        /// CAOMC3.
        /// </summary>
        public const string CAOMC3 = "CAOMC3";

        /// <summary>
        /// CAOMC4.
        /// </summary>
        public const string CAOMC4 = "CAOMC4";

        /// <summary>
        /// CAOMC5.
        /// </summary>
        public const string CAOMC5 = "CAOMC5";

        /// <summary>
        /// CAOM01.
        /// </summary>
        public const string CAOM01 = "CAOM01";

        /// <summary>
        /// CAOM02.
        /// </summary>
        public const string CAOM02 = "CAOM02";

        /// <summary>
        /// CAOM03.
        /// </summary>
        public const string CAOM03 = "CAOM03";

        /// <summary>
        /// CAOM04.
        /// </summary>
        public const string CAOM04 = "CAOM04";

        /// <summary>
        /// CAOM05.
        /// </summary>
        public const string CAOM05 = "CAOM05";

        /// <summary>
        /// CACPOT.
        /// </summary>
        public const string CACPOT = "CACPOT";

        /// <summary>
        /// CARPOT.
        /// </summary>
        public const string CARPOT = "CARPOT";

        /// <summary>
        /// CAPPOT.
        /// </summary>
        public const string CAPPOT = "CAPPOT";

        /// <summary>
        /// CACLPO.
        /// </summary>
        public const string CACLPO = "CACLPO";

        /// <summary>
        /// CARLPO.
        /// </summary>
        public const string CARLPO = "CARLPO";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CACTID.
        /// </summary>
        public const string CACTID = "CACTID";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42A011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACANM", "CACANM", JdeDataType.Numeric, null, true, true),
        new JdeField("CACADE", "CACADE", JdeDataType.String, 80),
        new JdeField("CATPCA", "CATPCA", JdeDataType.String, 10),
        new JdeField("CASDCA", "CASDCA", JdeDataType.Numeric),
        new JdeField("CAEDCA", "CAEDCA", JdeDataType.Numeric),
        new JdeField("CATERI", "CATERI", JdeDataType.String, 10),
        new JdeField("CACHTY", "CACHTY", JdeDataType.String, 10),
        new JdeField("CACRCD", "CACRCD", JdeDataType.String, 6),
        new JdeField("CACTGT", "CACTGT", JdeDataType.Numeric),
        new JdeField("CACACU", "CACACU", JdeDataType.Numeric),
        new JdeField("CARTGT", "CARTGT", JdeDataType.Numeric),
        new JdeField("CACRSP", "CACRSP", JdeDataType.Numeric),
        new JdeField("CACRNS", "CACRNS", JdeDataType.Numeric),
        new JdeField("CACARQ", "CACARQ", JdeDataType.Numeric),
        new JdeField("CALBGT", "CALBGT", JdeDataType.Numeric),
        new JdeField("CALACT", "CALACT", JdeDataType.Numeric),
        new JdeField("CAQLBU", "CAQLBU", JdeDataType.Numeric),
        new JdeField("CAQLAT", "CAQLAT", JdeDataType.Numeric),
        new JdeField("CAOMC1", "CAOMC1", JdeDataType.String, 6),
        new JdeField("CAOMC2", "CAOMC2", JdeDataType.String, 6),
        new JdeField("CAOMC3", "CAOMC3", JdeDataType.String, 6),
        new JdeField("CAOMC4", "CAOMC4", JdeDataType.String, 6),
        new JdeField("CAOMC5", "CAOMC5", JdeDataType.String, 6),
        new JdeField("CAOM01", "CAOM01", JdeDataType.String, 6),
        new JdeField("CAOM02", "CAOM02", JdeDataType.String, 6),
        new JdeField("CAOM03", "CAOM03", JdeDataType.String, 6),
        new JdeField("CAOM04", "CAOM04", JdeDataType.String, 6),
        new JdeField("CAOM05", "CAOM05", JdeDataType.String, 6),
        new JdeField("CACPOT", "CACPOT", JdeDataType.Numeric),
        new JdeField("CARPOT", "CARPOT", JdeDataType.Numeric),
        new JdeField("CAPPOT", "CAPPOT", JdeDataType.Numeric),
        new JdeField("CACLPO", "CACLPO", JdeDataType.Numeric),
        new JdeField("CARLPO", "CARLPO", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CACTID", "CACTID", JdeDataType.String, 30),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42A011_0", "Primary Key on CACANM", new[] { "CACANM" }, isUnique: true, isPrimaryKey: true)
    };
}
