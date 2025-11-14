using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1630 - .
/// </summary>
public class F1630 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDRCD.
        /// </summary>
        public const string CDDRCD = "CDDRCD";

        /// <summary>
        /// CDDL01.
        /// </summary>
        public const string CDDL01 = "CDDL01";

        /// <summary>
        /// CDDCM.
        /// </summary>
        public const string CDDCM = "CDDCM";

        /// <summary>
        /// CDFILE.
        /// </summary>
        public const string CDFILE = "CDFILE";

        /// <summary>
        /// CDDCAL.
        /// </summary>
        public const string CDDCAL = "CDDCAL";

        /// <summary>
        /// CDDTAI.
        /// </summary>
        public const string CDDTAI = "CDDTAI";

        /// <summary>
        /// CDDCFT.
        /// </summary>
        public const string CDDCFT = "CDDCFT";

        /// <summary>
        /// CDUOM.
        /// </summary>
        public const string CDUOM = "CDUOM";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDDTI1.
        /// </summary>
        public const string CDDTI1 = "CDDTI1";

        /// <summary>
        /// CDABT1.
        /// </summary>
        public const string CDABT1 = "CDABT1";

        /// <summary>
        /// CDDCF1.
        /// </summary>
        public const string CDDCF1 = "CDDCF1";

        /// <summary>
        /// CDDTI2.
        /// </summary>
        public const string CDDTI2 = "CDDTI2";

        /// <summary>
        /// CDABT2.
        /// </summary>
        public const string CDABT2 = "CDABT2";

        /// <summary>
        /// CDDCF2.
        /// </summary>
        public const string CDDCF2 = "CDDCF2";

        /// <summary>
        /// CDDTI3.
        /// </summary>
        public const string CDDTI3 = "CDDTI3";

        /// <summary>
        /// CDABT3.
        /// </summary>
        public const string CDABT3 = "CDABT3";

        /// <summary>
        /// CDDCF3.
        /// </summary>
        public const string CDDCF3 = "CDDCF3";

        /// <summary>
        /// CDDTI4.
        /// </summary>
        public const string CDDTI4 = "CDDTI4";

        /// <summary>
        /// CDABT4.
        /// </summary>
        public const string CDABT4 = "CDABT4";

        /// <summary>
        /// CDDCF4.
        /// </summary>
        public const string CDDCF4 = "CDDCF4";

        /// <summary>
        /// CDDTI5.
        /// </summary>
        public const string CDDTI5 = "CDDTI5";

        /// <summary>
        /// CDDTI6.
        /// </summary>
        public const string CDDTI6 = "CDDTI6";

        /// <summary>
        /// CDDTI7.
        /// </summary>
        public const string CDDTI7 = "CDDTI7";

        /// <summary>
        /// CDDTI8.
        /// </summary>
        public const string CDDTI8 = "CDDTI8";

        /// <summary>
        /// CDSBLT.
        /// </summary>
        public const string CDSBLT = "CDSBLT";

        /// <summary>
        /// CDDCC1.
        /// </summary>
        public const string CDDCC1 = "CDDCC1";

        /// <summary>
        /// CDDCC2.
        /// </summary>
        public const string CDDCC2 = "CDDCC2";

        /// <summary>
        /// CDDCC3.
        /// </summary>
        public const string CDDCC3 = "CDDCC3";

        /// <summary>
        /// CDDCC4.
        /// </summary>
        public const string CDDCC4 = "CDDCC4";

        /// <summary>
        /// CDDCC5.
        /// </summary>
        public const string CDDCC5 = "CDDCC5";

        /// <summary>
        /// CDEV01.
        /// </summary>
        public const string CDEV01 = "CDEV01";

        /// <summary>
        /// CDCO06.
        /// </summary>
        public const string CDCO06 = "CDCO06";

        /// <summary>
        /// CDCO07.
        /// </summary>
        public const string CDCO07 = "CDCO07";

        /// <summary>
        /// CDCO08.
        /// </summary>
        public const string CDCO08 = "CDCO08";

        /// <summary>
        /// CDCO09.
        /// </summary>
        public const string CDCO09 = "CDCO09";

        /// <summary>
        /// CDCO10.
        /// </summary>
        public const string CDCO10 = "CDCO10";

        /// <summary>
        /// CDDTFR.
        /// </summary>
        public const string CDDTFR = "CDDTFR";

        /// <summary>
        /// CDDTTO.
        /// </summary>
        public const string CDDTTO = "CDDTTO";

        /// <summary>
        /// CDVERS.
        /// </summary>
        public const string CDVERS = "CDVERS";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDTDAY.
        /// </summary>
        public const string CDTDAY = "CDTDAY";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDCPMA.
        /// </summary>
        public const string CDCPMA = "CDCPMA";

        /// <summary>
        /// CDDFIT.
        /// </summary>
        public const string CDDFIT = "CDDFIT";

        /// <summary>
        /// CDDFAT.
        /// </summary>
        public const string CDDFAT = "CDDFAT";
    }

    /// <inheritdoc />
    public override string TableName => "F1630";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDRCD", "CDDRCD", JdeDataType.String, 20, true, true),
        new JdeField("CDDL01", "CDDL01", JdeDataType.String, 60),
        new JdeField("CDDCM", "CDDCM", JdeDataType.String, 2),
        new JdeField("CDFILE", "CDFILE", JdeDataType.String, 20),
        new JdeField("CDDCAL", "CDDCAL", JdeDataType.String, 10),
        new JdeField("CDDTAI", "CDDTAI", JdeDataType.String, 20),
        new JdeField("CDDCFT", "CDDCFT", JdeDataType.String, 2),
        new JdeField("CDUOM", "CDUOM", JdeDataType.String, 4),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDDTI1", "CDDTI1", JdeDataType.String, 20),
        new JdeField("CDABT1", "CDABT1", JdeDataType.String, 2),
        new JdeField("CDDCF1", "CDDCF1", JdeDataType.String, 20),
        new JdeField("CDDTI2", "CDDTI2", JdeDataType.String, 20),
        new JdeField("CDABT2", "CDABT2", JdeDataType.String, 2),
        new JdeField("CDDCF2", "CDDCF2", JdeDataType.String, 20),
        new JdeField("CDDTI3", "CDDTI3", JdeDataType.String, 20),
        new JdeField("CDABT3", "CDABT3", JdeDataType.String, 2),
        new JdeField("CDDCF3", "CDDCF3", JdeDataType.String, 20),
        new JdeField("CDDTI4", "CDDTI4", JdeDataType.String, 20),
        new JdeField("CDABT4", "CDABT4", JdeDataType.String, 2),
        new JdeField("CDDCF4", "CDDCF4", JdeDataType.String, 20),
        new JdeField("CDDTI5", "CDDTI5", JdeDataType.String, 20),
        new JdeField("CDDTI6", "CDDTI6", JdeDataType.String, 20),
        new JdeField("CDDTI7", "CDDTI7", JdeDataType.String, 20),
        new JdeField("CDDTI8", "CDDTI8", JdeDataType.String, 20),
        new JdeField("CDSBLT", "CDSBLT", JdeDataType.String, 2),
        new JdeField("CDDCC1", "CDDCC1", JdeDataType.String, 20),
        new JdeField("CDDCC2", "CDDCC2", JdeDataType.String, 20),
        new JdeField("CDDCC3", "CDDCC3", JdeDataType.String, 20),
        new JdeField("CDDCC4", "CDDCC4", JdeDataType.String, 20),
        new JdeField("CDDCC5", "CDDCC5", JdeDataType.String, 20),
        new JdeField("CDEV01", "CDEV01", JdeDataType.String, 2),
        new JdeField("CDCO06", "CDCO06", JdeDataType.String, 2),
        new JdeField("CDCO07", "CDCO07", JdeDataType.String, 2),
        new JdeField("CDCO08", "CDCO08", JdeDataType.String, 2),
        new JdeField("CDCO09", "CDCO09", JdeDataType.String, 2),
        new JdeField("CDCO10", "CDCO10", JdeDataType.String, 2),
        new JdeField("CDDTFR", "CDDTFR", JdeDataType.Numeric),
        new JdeField("CDDTTO", "CDDTTO", JdeDataType.Numeric),
        new JdeField("CDVERS", "CDVERS", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDTDAY", "CDTDAY", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDCPMA", "CDCPMA", JdeDataType.Numeric),
        new JdeField("CDDFIT", "CDDFIT", JdeDataType.String, 2),
        new JdeField("CDDFAT", "CDDFAT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1630_0", "Primary Key on CDDRCD", new[] { "CDDRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
