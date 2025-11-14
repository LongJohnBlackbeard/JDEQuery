using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X30 - .
/// </summary>
public class F51X30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBJOBS.
        /// </summary>
        public const string PBJOBS = "PBJOBS";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBUPMT.
        /// </summary>
        public const string PBUPMT = "PBUPMT";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PB51XDTOPT.
        /// </summary>
        public const string PB51XDTOPT = "PB51XDTOPT";

        /// <summary>
        /// PB51XLODT.
        /// </summary>
        public const string PB51XLODT = "PB51XLODT";

        /// <summary>
        /// PB51XSUM.
        /// </summary>
        public const string PB51XSUM = "PB51XSUM";

        /// <summary>
        /// PBDTAI.
        /// </summary>
        public const string PBDTAI = "PBDTAI";

        /// <summary>
        /// PB51XCCCT.
        /// </summary>
        public const string PB51XCCCT = "PB51XCCCT";

        /// <summary>
        /// PB51XFPN.
        /// </summary>
        public const string PB51XFPN = "PB51XFPN";

        /// <summary>
        /// PB51XTPN.
        /// </summary>
        public const string PB51XTPN = "PB51XTPN";

        /// <summary>
        /// PB51XFFY.
        /// </summary>
        public const string PB51XFFY = "PB51XFFY";

        /// <summary>
        /// PB51XTFY.
        /// </summary>
        public const string PB51XTFY = "PB51XTFY";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBMKEY.
        /// </summary>
        public const string PBMKEY = "PBMKEY";

        /// <summary>
        /// PB51XCOL01.
        /// </summary>
        public const string PB51XCOL01 = "PB51XCOL01";

        /// <summary>
        /// PB51XCOL02.
        /// </summary>
        public const string PB51XCOL02 = "PB51XCOL02";

        /// <summary>
        /// PB51XCOL03.
        /// </summary>
        public const string PB51XCOL03 = "PB51XCOL03";

        /// <summary>
        /// PB51XCOL04.
        /// </summary>
        public const string PB51XCOL04 = "PB51XCOL04";

        /// <summary>
        /// PB51XCOL05.
        /// </summary>
        public const string PB51XCOL05 = "PB51XCOL05";

        /// <summary>
        /// PB51XCOL06.
        /// </summary>
        public const string PB51XCOL06 = "PB51XCOL06";

        /// <summary>
        /// PB51XCOL07.
        /// </summary>
        public const string PB51XCOL07 = "PB51XCOL07";

        /// <summary>
        /// PB51XCOL08.
        /// </summary>
        public const string PB51XCOL08 = "PB51XCOL08";

        /// <summary>
        /// PB51XCOL09.
        /// </summary>
        public const string PB51XCOL09 = "PB51XCOL09";

        /// <summary>
        /// PB51XCOL10.
        /// </summary>
        public const string PB51XCOL10 = "PB51XCOL10";

        /// <summary>
        /// PB51XCOL11.
        /// </summary>
        public const string PB51XCOL11 = "PB51XCOL11";

        /// <summary>
        /// PB51XCOL12.
        /// </summary>
        public const string PB51XCOL12 = "PB51XCOL12";

        /// <summary>
        /// PB51XCOL13.
        /// </summary>
        public const string PB51XCOL13 = "PB51XCOL13";

        /// <summary>
        /// PB51XCOL14.
        /// </summary>
        public const string PB51XCOL14 = "PB51XCOL14";

        /// <summary>
        /// PB51XCOL15.
        /// </summary>
        public const string PB51XCOL15 = "PB51XCOL15";

        /// <summary>
        /// PB51XCOL16.
        /// </summary>
        public const string PB51XCOL16 = "PB51XCOL16";

        /// <summary>
        /// PB51XCOL17.
        /// </summary>
        public const string PB51XCOL17 = "PB51XCOL17";

        /// <summary>
        /// PB51XCOL18.
        /// </summary>
        public const string PB51XCOL18 = "PB51XCOL18";

        /// <summary>
        /// PB51XCOL19.
        /// </summary>
        public const string PB51XCOL19 = "PB51XCOL19";

        /// <summary>
        /// PB51XCOL20.
        /// </summary>
        public const string PB51XCOL20 = "PB51XCOL20";

        /// <summary>
        /// PB51XCOL21.
        /// </summary>
        public const string PB51XCOL21 = "PB51XCOL21";

        /// <summary>
        /// PB51XCOL22.
        /// </summary>
        public const string PB51XCOL22 = "PB51XCOL22";

        /// <summary>
        /// PB51XCOL23.
        /// </summary>
        public const string PB51XCOL23 = "PB51XCOL23";

        /// <summary>
        /// PB51XCOL24.
        /// </summary>
        public const string PB51XCOL24 = "PB51XCOL24";

        /// <summary>
        /// PB51XCOL25.
        /// </summary>
        public const string PB51XCOL25 = "PB51XCOL25";

        /// <summary>
        /// PB51XCOL26.
        /// </summary>
        public const string PB51XCOL26 = "PB51XCOL26";

        /// <summary>
        /// PB51XCOL27.
        /// </summary>
        public const string PB51XCOL27 = "PB51XCOL27";

        /// <summary>
        /// PB51XCOL28.
        /// </summary>
        public const string PB51XCOL28 = "PB51XCOL28";

        /// <summary>
        /// PB51XCOL29.
        /// </summary>
        public const string PB51XCOL29 = "PB51XCOL29";

        /// <summary>
        /// PB51XCOL30.
        /// </summary>
        public const string PB51XCOL30 = "PB51XCOL30";

        /// <summary>
        /// PB51XCOL31.
        /// </summary>
        public const string PB51XCOL31 = "PB51XCOL31";

        /// <summary>
        /// PB51XCOL32.
        /// </summary>
        public const string PB51XCOL32 = "PB51XCOL32";

        /// <summary>
        /// PB51XCOL33.
        /// </summary>
        public const string PB51XCOL33 = "PB51XCOL33";

        /// <summary>
        /// PB51XCOL34.
        /// </summary>
        public const string PB51XCOL34 = "PB51XCOL34";

        /// <summary>
        /// PB51XCOL35.
        /// </summary>
        public const string PB51XCOL35 = "PB51XCOL35";

        /// <summary>
        /// PB51XCOL36.
        /// </summary>
        public const string PB51XCOL36 = "PB51XCOL36";

        /// <summary>
        /// PB51XCOL37.
        /// </summary>
        public const string PB51XCOL37 = "PB51XCOL37";

        /// <summary>
        /// PB51XCOL38.
        /// </summary>
        public const string PB51XCOL38 = "PB51XCOL38";

        /// <summary>
        /// PB51XCOL39.
        /// </summary>
        public const string PB51XCOL39 = "PB51XCOL39";

        /// <summary>
        /// PB51XCOL40.
        /// </summary>
        public const string PB51XCOL40 = "PB51XCOL40";

        /// <summary>
        /// PB51X01IC.
        /// </summary>
        public const string PB51X01IC = "PB51X01IC";

        /// <summary>
        /// PB51X02IC.
        /// </summary>
        public const string PB51X02IC = "PB51X02IC";

        /// <summary>
        /// PB51X03IC.
        /// </summary>
        public const string PB51X03IC = "PB51X03IC";

        /// <summary>
        /// PB51X04IC.
        /// </summary>
        public const string PB51X04IC = "PB51X04IC";

        /// <summary>
        /// PB51X05IC.
        /// </summary>
        public const string PB51X05IC = "PB51X05IC";

        /// <summary>
        /// PB51X06IC.
        /// </summary>
        public const string PB51X06IC = "PB51X06IC";

        /// <summary>
        /// PB51X07IC.
        /// </summary>
        public const string PB51X07IC = "PB51X07IC";

        /// <summary>
        /// PB51X08IC.
        /// </summary>
        public const string PB51X08IC = "PB51X08IC";

        /// <summary>
        /// PB51X09IC.
        /// </summary>
        public const string PB51X09IC = "PB51X09IC";

        /// <summary>
        /// PB51X10IC.
        /// </summary>
        public const string PB51X10IC = "PB51X10IC";

        /// <summary>
        /// PB51X11IC.
        /// </summary>
        public const string PB51X11IC = "PB51X11IC";

        /// <summary>
        /// PB51X12IC.
        /// </summary>
        public const string PB51X12IC = "PB51X12IC";

        /// <summary>
        /// PB51X13IC.
        /// </summary>
        public const string PB51X13IC = "PB51X13IC";

        /// <summary>
        /// PB51X14IC.
        /// </summary>
        public const string PB51X14IC = "PB51X14IC";

        /// <summary>
        /// PB51X15IC.
        /// </summary>
        public const string PB51X15IC = "PB51X15IC";

        /// <summary>
        /// PB51X16IC.
        /// </summary>
        public const string PB51X16IC = "PB51X16IC";

        /// <summary>
        /// PB51X17IC.
        /// </summary>
        public const string PB51X17IC = "PB51X17IC";

        /// <summary>
        /// PB51X18IC.
        /// </summary>
        public const string PB51X18IC = "PB51X18IC";

        /// <summary>
        /// PB51X19IC.
        /// </summary>
        public const string PB51X19IC = "PB51X19IC";

        /// <summary>
        /// PB51X20IC.
        /// </summary>
        public const string PB51X20IC = "PB51X20IC";

        /// <summary>
        /// PB51X21IC.
        /// </summary>
        public const string PB51X21IC = "PB51X21IC";

        /// <summary>
        /// PB51X22IC.
        /// </summary>
        public const string PB51X22IC = "PB51X22IC";

        /// <summary>
        /// PB51X23IC.
        /// </summary>
        public const string PB51X23IC = "PB51X23IC";

        /// <summary>
        /// PB51X24IC.
        /// </summary>
        public const string PB51X24IC = "PB51X24IC";

        /// <summary>
        /// PB51X25IC.
        /// </summary>
        public const string PB51X25IC = "PB51X25IC";

        /// <summary>
        /// PB51X26IC.
        /// </summary>
        public const string PB51X26IC = "PB51X26IC";

        /// <summary>
        /// PB51X27IC.
        /// </summary>
        public const string PB51X27IC = "PB51X27IC";

        /// <summary>
        /// PB51X28IC.
        /// </summary>
        public const string PB51X28IC = "PB51X28IC";

        /// <summary>
        /// PB51X29IC.
        /// </summary>
        public const string PB51X29IC = "PB51X29IC";

        /// <summary>
        /// PB51X30IC.
        /// </summary>
        public const string PB51X30IC = "PB51X30IC";

        /// <summary>
        /// PB51X31IC.
        /// </summary>
        public const string PB51X31IC = "PB51X31IC";

        /// <summary>
        /// PB51X32IC.
        /// </summary>
        public const string PB51X32IC = "PB51X32IC";

        /// <summary>
        /// PB51X33IC.
        /// </summary>
        public const string PB51X33IC = "PB51X33IC";

        /// <summary>
        /// PB51X34IC.
        /// </summary>
        public const string PB51X34IC = "PB51X34IC";

        /// <summary>
        /// PB51X35IC.
        /// </summary>
        public const string PB51X35IC = "PB51X35IC";

        /// <summary>
        /// PB51X36IC.
        /// </summary>
        public const string PB51X36IC = "PB51X36IC";

        /// <summary>
        /// PB51X37IC.
        /// </summary>
        public const string PB51X37IC = "PB51X37IC";

        /// <summary>
        /// PB51X38IC.
        /// </summary>
        public const string PB51X38IC = "PB51X38IC";

        /// <summary>
        /// PB51X39IC.
        /// </summary>
        public const string PB51X39IC = "PB51X39IC";

        /// <summary>
        /// PB51X40IC.
        /// </summary>
        public const string PB51X40IC = "PB51X40IC";

        /// <summary>
        /// PB51XDTAI1.
        /// </summary>
        public const string PB51XDTAI1 = "PB51XDTAI1";

        /// <summary>
        /// PB51XDTAI2.
        /// </summary>
        public const string PB51XDTAI2 = "PB51XDTAI2";

        /// <summary>
        /// PBSBL.
        /// </summary>
        public const string PBSBL = "PBSBL";

        /// <summary>
        /// PBSBLT.
        /// </summary>
        public const string PBSBLT = "PBSBLT";

        /// <summary>
        /// PBEFTB.
        /// </summary>
        public const string PBEFTB = "PBEFTB";

        /// <summary>
        /// PBEFTE.
        /// </summary>
        public const string PBEFTE = "PBEFTE";

        /// <summary>
        /// PB51XDTAI3.
        /// </summary>
        public const string PB51XDTAI3 = "PB51XDTAI3";

        /// <summary>
        /// PB51XPOD.
        /// </summary>
        public const string PB51XPOD = "PB51XPOD";

        /// <summary>
        /// PB51XEOS.
        /// </summary>
        public const string PB51XEOS = "PB51XEOS";

        /// <summary>
        /// PB51XDL01.
        /// </summary>
        public const string PB51XDL01 = "PB51XDL01";

        /// <summary>
        /// PBCRCD.
        /// </summary>
        public const string PBCRCD = "PBCRCD";

        /// <summary>
        /// PBAITD.
        /// </summary>
        public const string PBAITD = "PBAITD";

        /// <summary>
        /// PB51XARN.
        /// </summary>
        public const string PB51XARN = "PB51XARN";
    }

    /// <inheritdoc />
    public override string TableName => "F51X30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBJOBS", "PBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBUPMT", "PBUPMT", JdeDataType.Numeric),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PB51XDTOPT", "PB51XDTOPT", JdeDataType.String, 2),
        new JdeField("PB51XLODT", "PB51XLODT", JdeDataType.String, 2),
        new JdeField("PB51XSUM", "PB51XSUM", JdeDataType.String, 8),
        new JdeField("PBDTAI", "PBDTAI", JdeDataType.String, 20),
        new JdeField("PB51XCCCT", "PB51XCCCT", JdeDataType.String, 2),
        new JdeField("PB51XFPN", "PB51XFPN", JdeDataType.Numeric),
        new JdeField("PB51XTPN", "PB51XTPN", JdeDataType.Numeric),
        new JdeField("PB51XFFY", "PB51XFFY", JdeDataType.Numeric),
        new JdeField("PB51XTFY", "PB51XTFY", JdeDataType.Numeric),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBMKEY", "PBMKEY", JdeDataType.String, 30),
        new JdeField("PB51XCOL01", "PB51XCOL01", JdeDataType.String, 12),
        new JdeField("PB51XCOL02", "PB51XCOL02", JdeDataType.String, 12),
        new JdeField("PB51XCOL03", "PB51XCOL03", JdeDataType.String, 12),
        new JdeField("PB51XCOL04", "PB51XCOL04", JdeDataType.String, 12),
        new JdeField("PB51XCOL05", "PB51XCOL05", JdeDataType.String, 12),
        new JdeField("PB51XCOL06", "PB51XCOL06", JdeDataType.String, 12),
        new JdeField("PB51XCOL07", "PB51XCOL07", JdeDataType.String, 12),
        new JdeField("PB51XCOL08", "PB51XCOL08", JdeDataType.String, 12),
        new JdeField("PB51XCOL09", "PB51XCOL09", JdeDataType.String, 12),
        new JdeField("PB51XCOL10", "PB51XCOL10", JdeDataType.String, 12),
        new JdeField("PB51XCOL11", "PB51XCOL11", JdeDataType.String, 12),
        new JdeField("PB51XCOL12", "PB51XCOL12", JdeDataType.String, 12),
        new JdeField("PB51XCOL13", "PB51XCOL13", JdeDataType.String, 12),
        new JdeField("PB51XCOL14", "PB51XCOL14", JdeDataType.String, 12),
        new JdeField("PB51XCOL15", "PB51XCOL15", JdeDataType.String, 12),
        new JdeField("PB51XCOL16", "PB51XCOL16", JdeDataType.String, 12),
        new JdeField("PB51XCOL17", "PB51XCOL17", JdeDataType.String, 12),
        new JdeField("PB51XCOL18", "PB51XCOL18", JdeDataType.String, 12),
        new JdeField("PB51XCOL19", "PB51XCOL19", JdeDataType.String, 12),
        new JdeField("PB51XCOL20", "PB51XCOL20", JdeDataType.String, 12),
        new JdeField("PB51XCOL21", "PB51XCOL21", JdeDataType.String, 12),
        new JdeField("PB51XCOL22", "PB51XCOL22", JdeDataType.String, 12),
        new JdeField("PB51XCOL23", "PB51XCOL23", JdeDataType.String, 12),
        new JdeField("PB51XCOL24", "PB51XCOL24", JdeDataType.String, 12),
        new JdeField("PB51XCOL25", "PB51XCOL25", JdeDataType.String, 12),
        new JdeField("PB51XCOL26", "PB51XCOL26", JdeDataType.String, 12),
        new JdeField("PB51XCOL27", "PB51XCOL27", JdeDataType.String, 12),
        new JdeField("PB51XCOL28", "PB51XCOL28", JdeDataType.String, 12),
        new JdeField("PB51XCOL29", "PB51XCOL29", JdeDataType.String, 12),
        new JdeField("PB51XCOL30", "PB51XCOL30", JdeDataType.String, 12),
        new JdeField("PB51XCOL31", "PB51XCOL31", JdeDataType.String, 12),
        new JdeField("PB51XCOL32", "PB51XCOL32", JdeDataType.String, 12),
        new JdeField("PB51XCOL33", "PB51XCOL33", JdeDataType.String, 12),
        new JdeField("PB51XCOL34", "PB51XCOL34", JdeDataType.String, 12),
        new JdeField("PB51XCOL35", "PB51XCOL35", JdeDataType.String, 12),
        new JdeField("PB51XCOL36", "PB51XCOL36", JdeDataType.String, 12),
        new JdeField("PB51XCOL37", "PB51XCOL37", JdeDataType.String, 12),
        new JdeField("PB51XCOL38", "PB51XCOL38", JdeDataType.String, 12),
        new JdeField("PB51XCOL39", "PB51XCOL39", JdeDataType.String, 12),
        new JdeField("PB51XCOL40", "PB51XCOL40", JdeDataType.String, 12),
        new JdeField("PB51X01IC", "PB51X01IC", JdeDataType.String, 2),
        new JdeField("PB51X02IC", "PB51X02IC", JdeDataType.String, 2),
        new JdeField("PB51X03IC", "PB51X03IC", JdeDataType.String, 2),
        new JdeField("PB51X04IC", "PB51X04IC", JdeDataType.String, 2),
        new JdeField("PB51X05IC", "PB51X05IC", JdeDataType.String, 2),
        new JdeField("PB51X06IC", "PB51X06IC", JdeDataType.String, 2),
        new JdeField("PB51X07IC", "PB51X07IC", JdeDataType.String, 2),
        new JdeField("PB51X08IC", "PB51X08IC", JdeDataType.String, 2),
        new JdeField("PB51X09IC", "PB51X09IC", JdeDataType.String, 2),
        new JdeField("PB51X10IC", "PB51X10IC", JdeDataType.String, 2),
        new JdeField("PB51X11IC", "PB51X11IC", JdeDataType.String, 2),
        new JdeField("PB51X12IC", "PB51X12IC", JdeDataType.String, 2),
        new JdeField("PB51X13IC", "PB51X13IC", JdeDataType.String, 2),
        new JdeField("PB51X14IC", "PB51X14IC", JdeDataType.String, 2),
        new JdeField("PB51X15IC", "PB51X15IC", JdeDataType.String, 2),
        new JdeField("PB51X16IC", "PB51X16IC", JdeDataType.String, 2),
        new JdeField("PB51X17IC", "PB51X17IC", JdeDataType.String, 2),
        new JdeField("PB51X18IC", "PB51X18IC", JdeDataType.String, 2),
        new JdeField("PB51X19IC", "PB51X19IC", JdeDataType.String, 2),
        new JdeField("PB51X20IC", "PB51X20IC", JdeDataType.String, 2),
        new JdeField("PB51X21IC", "PB51X21IC", JdeDataType.String, 2),
        new JdeField("PB51X22IC", "PB51X22IC", JdeDataType.String, 2),
        new JdeField("PB51X23IC", "PB51X23IC", JdeDataType.String, 2),
        new JdeField("PB51X24IC", "PB51X24IC", JdeDataType.String, 2),
        new JdeField("PB51X25IC", "PB51X25IC", JdeDataType.String, 2),
        new JdeField("PB51X26IC", "PB51X26IC", JdeDataType.String, 2),
        new JdeField("PB51X27IC", "PB51X27IC", JdeDataType.String, 2),
        new JdeField("PB51X28IC", "PB51X28IC", JdeDataType.String, 2),
        new JdeField("PB51X29IC", "PB51X29IC", JdeDataType.String, 2),
        new JdeField("PB51X30IC", "PB51X30IC", JdeDataType.String, 2),
        new JdeField("PB51X31IC", "PB51X31IC", JdeDataType.String, 2),
        new JdeField("PB51X32IC", "PB51X32IC", JdeDataType.String, 2),
        new JdeField("PB51X33IC", "PB51X33IC", JdeDataType.String, 2),
        new JdeField("PB51X34IC", "PB51X34IC", JdeDataType.String, 2),
        new JdeField("PB51X35IC", "PB51X35IC", JdeDataType.String, 2),
        new JdeField("PB51X36IC", "PB51X36IC", JdeDataType.String, 2),
        new JdeField("PB51X37IC", "PB51X37IC", JdeDataType.String, 2),
        new JdeField("PB51X38IC", "PB51X38IC", JdeDataType.String, 2),
        new JdeField("PB51X39IC", "PB51X39IC", JdeDataType.String, 2),
        new JdeField("PB51X40IC", "PB51X40IC", JdeDataType.String, 2),
        new JdeField("PB51XDTAI1", "PB51XDTAI1", JdeDataType.String, 20),
        new JdeField("PB51XDTAI2", "PB51XDTAI2", JdeDataType.String, 20),
        new JdeField("PBSBL", "PBSBL", JdeDataType.String, 16),
        new JdeField("PBSBLT", "PBSBLT", JdeDataType.String, 2),
        new JdeField("PBEFTB", "PBEFTB", JdeDataType.Numeric),
        new JdeField("PBEFTE", "PBEFTE", JdeDataType.Numeric),
        new JdeField("PB51XDTAI3", "PB51XDTAI3", JdeDataType.String, 20),
        new JdeField("PB51XPOD", "PB51XPOD", JdeDataType.String, 2),
        new JdeField("PB51XEOS", "PB51XEOS", JdeDataType.String, 2),
        new JdeField("PB51XDL01", "PB51XDL01", JdeDataType.String, 240),
        new JdeField("PBCRCD", "PBCRCD", JdeDataType.String, 6),
        new JdeField("PBAITD", "PBAITD", JdeDataType.Numeric),
        new JdeField("PB51XARN", "PB51XARN", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X30_0", "Primary Key on PBJOBS", new[] { "PBJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
