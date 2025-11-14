using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F83110B - .
/// </summary>
public class F83110B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHDTPN.
        /// </summary>
        public const string CHDTPN = "CHDTPN";

        /// <summary>
        /// CHLNGP.
        /// </summary>
        public const string CHLNGP = "CHLNGP";

        /// <summary>
        /// CHPNM01.
        /// </summary>
        public const string CHPNM01 = "CHPNM01";

        /// <summary>
        /// CHPNM02.
        /// </summary>
        public const string CHPNM02 = "CHPNM02";

        /// <summary>
        /// CHPNM03.
        /// </summary>
        public const string CHPNM03 = "CHPNM03";

        /// <summary>
        /// CHPNM04.
        /// </summary>
        public const string CHPNM04 = "CHPNM04";

        /// <summary>
        /// CHPNM05.
        /// </summary>
        public const string CHPNM05 = "CHPNM05";

        /// <summary>
        /// CHPNM06.
        /// </summary>
        public const string CHPNM06 = "CHPNM06";

        /// <summary>
        /// CHPNM07.
        /// </summary>
        public const string CHPNM07 = "CHPNM07";

        /// <summary>
        /// CHPNM08.
        /// </summary>
        public const string CHPNM08 = "CHPNM08";

        /// <summary>
        /// CHPNM09.
        /// </summary>
        public const string CHPNM09 = "CHPNM09";

        /// <summary>
        /// CHPNM10.
        /// </summary>
        public const string CHPNM10 = "CHPNM10";

        /// <summary>
        /// CHPNM11.
        /// </summary>
        public const string CHPNM11 = "CHPNM11";

        /// <summary>
        /// CHPNM12.
        /// </summary>
        public const string CHPNM12 = "CHPNM12";

        /// <summary>
        /// CHPNM13.
        /// </summary>
        public const string CHPNM13 = "CHPNM13";

        /// <summary>
        /// CHPNM14.
        /// </summary>
        public const string CHPNM14 = "CHPNM14";

        /// <summary>
        /// CHPNM15.
        /// </summary>
        public const string CHPNM15 = "CHPNM15";

        /// <summary>
        /// CHPNM16.
        /// </summary>
        public const string CHPNM16 = "CHPNM16";

        /// <summary>
        /// CHPNM17.
        /// </summary>
        public const string CHPNM17 = "CHPNM17";

        /// <summary>
        /// CHPNM18.
        /// </summary>
        public const string CHPNM18 = "CHPNM18";

        /// <summary>
        /// CHPNM19.
        /// </summary>
        public const string CHPNM19 = "CHPNM19";

        /// <summary>
        /// CHPNM20.
        /// </summary>
        public const string CHPNM20 = "CHPNM20";

        /// <summary>
        /// CHPNM21.
        /// </summary>
        public const string CHPNM21 = "CHPNM21";

        /// <summary>
        /// CHPNM22.
        /// </summary>
        public const string CHPNM22 = "CHPNM22";

        /// <summary>
        /// CHPNM23.
        /// </summary>
        public const string CHPNM23 = "CHPNM23";

        /// <summary>
        /// CHPNM24.
        /// </summary>
        public const string CHPNM24 = "CHPNM24";

        /// <summary>
        /// CHPNM25.
        /// </summary>
        public const string CHPNM25 = "CHPNM25";

        /// <summary>
        /// CHPNM26.
        /// </summary>
        public const string CHPNM26 = "CHPNM26";

        /// <summary>
        /// CHPNM27.
        /// </summary>
        public const string CHPNM27 = "CHPNM27";

        /// <summary>
        /// CHPNM28.
        /// </summary>
        public const string CHPNM28 = "CHPNM28";

        /// <summary>
        /// CHPNM29.
        /// </summary>
        public const string CHPNM29 = "CHPNM29";

        /// <summary>
        /// CHPNM30.
        /// </summary>
        public const string CHPNM30 = "CHPNM30";

        /// <summary>
        /// CHPNM31.
        /// </summary>
        public const string CHPNM31 = "CHPNM31";

        /// <summary>
        /// CHPNM32.
        /// </summary>
        public const string CHPNM32 = "CHPNM32";

        /// <summary>
        /// CHPNM33.
        /// </summary>
        public const string CHPNM33 = "CHPNM33";

        /// <summary>
        /// CHPNM34.
        /// </summary>
        public const string CHPNM34 = "CHPNM34";

        /// <summary>
        /// CHPNM35.
        /// </summary>
        public const string CHPNM35 = "CHPNM35";

        /// <summary>
        /// CHPNM36.
        /// </summary>
        public const string CHPNM36 = "CHPNM36";

        /// <summary>
        /// CHPNM37.
        /// </summary>
        public const string CHPNM37 = "CHPNM37";

        /// <summary>
        /// CHPNM38.
        /// </summary>
        public const string CHPNM38 = "CHPNM38";

        /// <summary>
        /// CHPNM39.
        /// </summary>
        public const string CHPNM39 = "CHPNM39";

        /// <summary>
        /// CHPNM40.
        /// </summary>
        public const string CHPNM40 = "CHPNM40";

        /// <summary>
        /// CHPNM41.
        /// </summary>
        public const string CHPNM41 = "CHPNM41";

        /// <summary>
        /// CHPNM42.
        /// </summary>
        public const string CHPNM42 = "CHPNM42";

        /// <summary>
        /// CHPNM43.
        /// </summary>
        public const string CHPNM43 = "CHPNM43";

        /// <summary>
        /// CHPNM44.
        /// </summary>
        public const string CHPNM44 = "CHPNM44";

        /// <summary>
        /// CHPNM45.
        /// </summary>
        public const string CHPNM45 = "CHPNM45";

        /// <summary>
        /// CHPNM46.
        /// </summary>
        public const string CHPNM46 = "CHPNM46";

        /// <summary>
        /// CHPNM47.
        /// </summary>
        public const string CHPNM47 = "CHPNM47";

        /// <summary>
        /// CHPNM48.
        /// </summary>
        public const string CHPNM48 = "CHPNM48";

        /// <summary>
        /// CHPNM49.
        /// </summary>
        public const string CHPNM49 = "CHPNM49";

        /// <summary>
        /// CHPNM50.
        /// </summary>
        public const string CHPNM50 = "CHPNM50";

        /// <summary>
        /// CHPNM51.
        /// </summary>
        public const string CHPNM51 = "CHPNM51";

        /// <summary>
        /// CHPNM52.
        /// </summary>
        public const string CHPNM52 = "CHPNM52";

        /// <summary>
        /// CHPNM53.
        /// </summary>
        public const string CHPNM53 = "CHPNM53";

        /// <summary>
        /// CHPNM54.
        /// </summary>
        public const string CHPNM54 = "CHPNM54";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F83110B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHDTPN", "CHDTPN", JdeDataType.String, 2, true, true),
        new JdeField("CHLNGP", "CHLNGP", JdeDataType.String, 4, true, true),
        new JdeField("CHPNM01", "CHPNM01", JdeDataType.String, 40),
        new JdeField("CHPNM02", "CHPNM02", JdeDataType.String, 40),
        new JdeField("CHPNM03", "CHPNM03", JdeDataType.String, 40),
        new JdeField("CHPNM04", "CHPNM04", JdeDataType.String, 40),
        new JdeField("CHPNM05", "CHPNM05", JdeDataType.String, 40),
        new JdeField("CHPNM06", "CHPNM06", JdeDataType.String, 40),
        new JdeField("CHPNM07", "CHPNM07", JdeDataType.String, 40),
        new JdeField("CHPNM08", "CHPNM08", JdeDataType.String, 40),
        new JdeField("CHPNM09", "CHPNM09", JdeDataType.String, 40),
        new JdeField("CHPNM10", "CHPNM10", JdeDataType.String, 40),
        new JdeField("CHPNM11", "CHPNM11", JdeDataType.String, 40),
        new JdeField("CHPNM12", "CHPNM12", JdeDataType.String, 40),
        new JdeField("CHPNM13", "CHPNM13", JdeDataType.String, 40),
        new JdeField("CHPNM14", "CHPNM14", JdeDataType.String, 40),
        new JdeField("CHPNM15", "CHPNM15", JdeDataType.String, 40),
        new JdeField("CHPNM16", "CHPNM16", JdeDataType.String, 40),
        new JdeField("CHPNM17", "CHPNM17", JdeDataType.String, 40),
        new JdeField("CHPNM18", "CHPNM18", JdeDataType.String, 40),
        new JdeField("CHPNM19", "CHPNM19", JdeDataType.String, 40),
        new JdeField("CHPNM20", "CHPNM20", JdeDataType.String, 40),
        new JdeField("CHPNM21", "CHPNM21", JdeDataType.String, 40),
        new JdeField("CHPNM22", "CHPNM22", JdeDataType.String, 40),
        new JdeField("CHPNM23", "CHPNM23", JdeDataType.String, 40),
        new JdeField("CHPNM24", "CHPNM24", JdeDataType.String, 40),
        new JdeField("CHPNM25", "CHPNM25", JdeDataType.String, 40),
        new JdeField("CHPNM26", "CHPNM26", JdeDataType.String, 40),
        new JdeField("CHPNM27", "CHPNM27", JdeDataType.String, 40),
        new JdeField("CHPNM28", "CHPNM28", JdeDataType.String, 40),
        new JdeField("CHPNM29", "CHPNM29", JdeDataType.String, 40),
        new JdeField("CHPNM30", "CHPNM30", JdeDataType.String, 40),
        new JdeField("CHPNM31", "CHPNM31", JdeDataType.String, 40),
        new JdeField("CHPNM32", "CHPNM32", JdeDataType.String, 40),
        new JdeField("CHPNM33", "CHPNM33", JdeDataType.String, 40),
        new JdeField("CHPNM34", "CHPNM34", JdeDataType.String, 40),
        new JdeField("CHPNM35", "CHPNM35", JdeDataType.String, 40),
        new JdeField("CHPNM36", "CHPNM36", JdeDataType.String, 40),
        new JdeField("CHPNM37", "CHPNM37", JdeDataType.String, 40),
        new JdeField("CHPNM38", "CHPNM38", JdeDataType.String, 40),
        new JdeField("CHPNM39", "CHPNM39", JdeDataType.String, 40),
        new JdeField("CHPNM40", "CHPNM40", JdeDataType.String, 40),
        new JdeField("CHPNM41", "CHPNM41", JdeDataType.String, 40),
        new JdeField("CHPNM42", "CHPNM42", JdeDataType.String, 40),
        new JdeField("CHPNM43", "CHPNM43", JdeDataType.String, 40),
        new JdeField("CHPNM44", "CHPNM44", JdeDataType.String, 40),
        new JdeField("CHPNM45", "CHPNM45", JdeDataType.String, 40),
        new JdeField("CHPNM46", "CHPNM46", JdeDataType.String, 40),
        new JdeField("CHPNM47", "CHPNM47", JdeDataType.String, 40),
        new JdeField("CHPNM48", "CHPNM48", JdeDataType.String, 40),
        new JdeField("CHPNM49", "CHPNM49", JdeDataType.String, 40),
        new JdeField("CHPNM50", "CHPNM50", JdeDataType.String, 40),
        new JdeField("CHPNM51", "CHPNM51", JdeDataType.String, 40),
        new JdeField("CHPNM52", "CHPNM52", JdeDataType.String, 40),
        new JdeField("CHPNM53", "CHPNM53", JdeDataType.String, 40),
        new JdeField("CHPNM54", "CHPNM54", JdeDataType.String, 40),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F83110B_0", "Primary Key on CHDTPN, CHLNGP", new[] { "CHDTPN", "CHLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
