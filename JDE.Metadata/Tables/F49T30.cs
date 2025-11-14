using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T30 - .
/// </summary>
public class F49T30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOOTBSHPN.
        /// </summary>
        public const string SOOTBSHPN = "SOOTBSHPN";

        /// <summary>
        /// SOOTORDRLS.
        /// </summary>
        public const string SOOTORDRLS = "SOOTORDRLS";

        /// <summary>
        /// SOOTORDRLN.
        /// </summary>
        public const string SOOTORDRLN = "SOOTORDRLN";

        /// <summary>
        /// SOSHPN.
        /// </summary>
        public const string SOSHPN = "SOSHPN";

        /// <summary>
        /// SOOTDOMAIN.
        /// </summary>
        public const string SOOTDOMAIN = "SOOTDOMAIN";

        /// <summary>
        /// SOOTLOCDOM.
        /// </summary>
        public const string SOOTLOCDOM = "SOOTLOCDOM";

        /// <summary>
        /// SOOTEQUIP.
        /// </summary>
        public const string SOOTEQUIP = "SOOTEQUIP";

        /// <summary>
        /// SOOTSTPSEQ.
        /// </summary>
        public const string SOOTSTPSEQ = "SOOTSTPSEQ";

        /// <summary>
        /// SOOTSHPUNT.
        /// </summary>
        public const string SOOTSHPUNT = "SOOTSHPUNT";

        /// <summary>
        /// SOOTITEMID.
        /// </summary>
        public const string SOOTITEMID = "SOOTITEMID";

        /// <summary>
        /// SOOTPKGITM.
        /// </summary>
        public const string SOOTPKGITM = "SOOTPKGITM";

        /// <summary>
        /// SOOTRSHUNT.
        /// </summary>
        public const string SOOTRSHUNT = "SOOTRSHUNT";

        /// <summary>
        /// SOADDJ.
        /// </summary>
        public const string SOADDJ = "SOADDJ";

        /// <summary>
        /// SOITVL.
        /// </summary>
        public const string SOITVL = "SOITVL";

        /// <summary>
        /// SOITWT.
        /// </summary>
        public const string SOITWT = "SOITWT";

        /// <summary>
        /// SOSOQS.
        /// </summary>
        public const string SOSOQS = "SOSOQS";

        /// <summary>
        /// SOOTSHPUCT.
        /// </summary>
        public const string SOOTSHPUCT = "SOOTSHPUCT";

        /// <summary>
        /// SOOTWTUOM.
        /// </summary>
        public const string SOOTWTUOM = "SOOTWTUOM";

        /// <summary>
        /// SOOTUNITWT.
        /// </summary>
        public const string SOOTUNITWT = "SOOTUNITWT";

        /// <summary>
        /// SOOTVOLUOM.
        /// </summary>
        public const string SOOTVOLUOM = "SOOTVOLUOM";

        /// <summary>
        /// SOOTUNITVL.
        /// </summary>
        public const string SOOTUNITVL = "SOOTUNITVL";

        /// <summary>
        /// SOEQT2.
        /// </summary>
        public const string SOEQT2 = "SOEQT2";

        /// <summary>
        /// SOCARS.
        /// </summary>
        public const string SOCARS = "SOCARS";

        /// <summary>
        /// SOOTE1REF1.
        /// </summary>
        public const string SOOTE1REF1 = "SOOTE1REF1";

        /// <summary>
        /// SOOTE1REF2.
        /// </summary>
        public const string SOOTE1REF2 = "SOOTE1REF2";

        /// <summary>
        /// SOOTE1REF3.
        /// </summary>
        public const string SOOTE1REF3 = "SOOTE1REF3";

        /// <summary>
        /// SOOTCHAR1.
        /// </summary>
        public const string SOOTCHAR1 = "SOOTCHAR1";

        /// <summary>
        /// SOOTCHAR2.
        /// </summary>
        public const string SOOTCHAR2 = "SOOTCHAR2";

        /// <summary>
        /// SOOTCHAR3.
        /// </summary>
        public const string SOOTCHAR3 = "SOOTCHAR3";

        /// <summary>
        /// SOOTMATH1.
        /// </summary>
        public const string SOOTMATH1 = "SOOTMATH1";

        /// <summary>
        /// SOOTMATH2.
        /// </summary>
        public const string SOOTMATH2 = "SOOTMATH2";

        /// <summary>
        /// SOOTMATH3.
        /// </summary>
        public const string SOOTMATH3 = "SOOTMATH3";

        /// <summary>
        /// SOURCD.
        /// </summary>
        public const string SOURCD = "SOURCD";

        /// <summary>
        /// SOURDT.
        /// </summary>
        public const string SOURDT = "SOURDT";

        /// <summary>
        /// SOURRF.
        /// </summary>
        public const string SOURRF = "SOURRF";

        /// <summary>
        /// SOURAT.
        /// </summary>
        public const string SOURAT = "SOURAT";

        /// <summary>
        /// SOURAB.
        /// </summary>
        public const string SOURAB = "SOURAB";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";

        /// <summary>
        /// SOTORG.
        /// </summary>
        public const string SOTORG = "SOTORG";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SOUUPMJ.
        /// </summary>
        public const string SOUUPMJ = "SOUUPMJ";

        /// <summary>
        /// SOOTEQUIP2.
        /// </summary>
        public const string SOOTEQUIP2 = "SOOTEQUIP2";

        /// <summary>
        /// SOADTM.
        /// </summary>
        public const string SOADTM = "SOADTM";
    }

    /// <inheritdoc />
    public override string TableName => "F49T30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOOTBSHPN", "SOOTBSHPN", JdeDataType.String, 100, true, true),
        new JdeField("SOOTORDRLS", "SOOTORDRLS", JdeDataType.String, 100, true, true),
        new JdeField("SOOTORDRLN", "SOOTORDRLN", JdeDataType.String, 100, true, true),
        new JdeField("SOSHPN", "SOSHPN", JdeDataType.Numeric),
        new JdeField("SOOTDOMAIN", "SOOTDOMAIN", JdeDataType.String, 100),
        new JdeField("SOOTLOCDOM", "SOOTLOCDOM", JdeDataType.String, 100),
        new JdeField("SOOTEQUIP", "SOOTEQUIP", JdeDataType.String, 100),
        new JdeField("SOOTSTPSEQ", "SOOTSTPSEQ", JdeDataType.Numeric),
        new JdeField("SOOTSHPUNT", "SOOTSHPUNT", JdeDataType.String, 100),
        new JdeField("SOOTITEMID", "SOOTITEMID", JdeDataType.String, 100),
        new JdeField("SOOTPKGITM", "SOOTPKGITM", JdeDataType.String, 100),
        new JdeField("SOOTRSHUNT", "SOOTRSHUNT", JdeDataType.String, 100),
        new JdeField("SOADDJ", "SOADDJ", JdeDataType.Numeric),
        new JdeField("SOITVL", "SOITVL", JdeDataType.Numeric),
        new JdeField("SOITWT", "SOITWT", JdeDataType.Numeric),
        new JdeField("SOSOQS", "SOSOQS", JdeDataType.Numeric),
        new JdeField("SOOTSHPUCT", "SOOTSHPUCT", JdeDataType.Numeric),
        new JdeField("SOOTWTUOM", "SOOTWTUOM", JdeDataType.String, 128),
        new JdeField("SOOTUNITWT", "SOOTUNITWT", JdeDataType.Numeric),
        new JdeField("SOOTVOLUOM", "SOOTVOLUOM", JdeDataType.String, 128),
        new JdeField("SOOTUNITVL", "SOOTUNITVL", JdeDataType.Numeric),
        new JdeField("SOEQT2", "SOEQT2", JdeDataType.String, 10),
        new JdeField("SOCARS", "SOCARS", JdeDataType.Numeric),
        new JdeField("SOOTE1REF1", "SOOTE1REF1", JdeDataType.String, 100),
        new JdeField("SOOTE1REF2", "SOOTE1REF2", JdeDataType.String, 100),
        new JdeField("SOOTE1REF3", "SOOTE1REF3", JdeDataType.String, 100),
        new JdeField("SOOTCHAR1", "SOOTCHAR1", JdeDataType.String, 2),
        new JdeField("SOOTCHAR2", "SOOTCHAR2", JdeDataType.String, 2),
        new JdeField("SOOTCHAR3", "SOOTCHAR3", JdeDataType.String, 2),
        new JdeField("SOOTMATH1", "SOOTMATH1", JdeDataType.Numeric),
        new JdeField("SOOTMATH2", "SOOTMATH2", JdeDataType.Numeric),
        new JdeField("SOOTMATH3", "SOOTMATH3", JdeDataType.Numeric),
        new JdeField("SOURCD", "SOURCD", JdeDataType.String, 4),
        new JdeField("SOURDT", "SOURDT", JdeDataType.Numeric),
        new JdeField("SOURRF", "SOURRF", JdeDataType.String, 30),
        new JdeField("SOURAT", "SOURAT", JdeDataType.Numeric),
        new JdeField("SOURAB", "SOURAB", JdeDataType.Numeric),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20),
        new JdeField("SOTORG", "SOTORG", JdeDataType.String, 20),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20),
        new JdeField("SOUUPMJ", "SOUUPMJ", JdeDataType.Date),
        new JdeField("SOOTEQUIP2", "SOOTEQUIP2", JdeDataType.String, 100),
        new JdeField("SOADTM", "SOADTM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T30_0", "Primary Key on SOOTBSHPN, SOOTORDRLS, SOOTORDRLN", new[] { "SOOTBSHPN", "SOOTORDRLS", "SOOTORDRLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T30_2", "Index on SOOTBSHPN, SOOTSHPUNT", new[] { "SOOTBSHPN", "SOOTSHPUNT" }),
        new JdeIndex("F49T30_3", "Index on SOOTBSHPN, SOOTSTPSEQ, SOOTSHPUNT", new[] { "SOOTBSHPN", "SOOTSTPSEQ", "SOOTSHPUNT" }),
        new JdeIndex("F49T30_4", "Index on SOOTORDRLS, SOOTORDRLN", new[] { "SOOTORDRLS", "SOOTORDRLN" })
    };
}
