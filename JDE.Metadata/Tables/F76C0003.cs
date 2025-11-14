using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0003 - .
/// </summary>
public class F76C0003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCO.
        /// </summary>
        public const string CRCO = "CRCO";

        /// <summary>
        /// CRVR01.
        /// </summary>
        public const string CRVR01 = "CRVR01";

        /// <summary>
        /// CRVR02.
        /// </summary>
        public const string CRVR02 = "CRVR02";

        /// <summary>
        /// CRPN.
        /// </summary>
        public const string CRPN = "CRPN";

        /// <summary>
        /// CR76CCD.
        /// </summary>
        public const string CR76CCD = "CR76CCD";

        /// <summary>
        /// CRAPDT.
        /// </summary>
        public const string CRAPDT = "CRAPDT";

        /// <summary>
        /// CRFY.
        /// </summary>
        public const string CRFY = "CRFY";

        /// <summary>
        /// CRRMK.
        /// </summary>
        public const string CRRMK = "CRRMK";

        /// <summary>
        /// CRCKDT.
        /// </summary>
        public const string CRCKDT = "CRCKDT";

        /// <summary>
        /// CRRMK2.
        /// </summary>
        public const string CRRMK2 = "CRRMK2";

        /// <summary>
        /// CRALP.
        /// </summary>
        public const string CRALP = "CRALP";

        /// <summary>
        /// CRCACT.
        /// </summary>
        public const string CRCACT = "CRCACT";

        /// <summary>
        /// CRPYID.
        /// </summary>
        public const string CRPYID = "CRPYID";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCO", "CRCO", JdeDataType.String, 10, true, true),
        new JdeField("CRVR01", "CRVR01", JdeDataType.String, 50, true, true),
        new JdeField("CRVR02", "CRVR02", JdeDataType.String, 50, true, true),
        new JdeField("CRPN", "CRPN", JdeDataType.Numeric),
        new JdeField("CR76CCD", "CR76CCD", JdeDataType.String, 4),
        new JdeField("CRAPDT", "CRAPDT", JdeDataType.Numeric),
        new JdeField("CRFY", "CRFY", JdeDataType.Numeric),
        new JdeField("CRRMK", "CRRMK", JdeDataType.String, 60),
        new JdeField("CRCKDT", "CRCKDT", JdeDataType.Numeric),
        new JdeField("CRRMK2", "CRRMK2", JdeDataType.String, 60),
        new JdeField("CRALP", "CRALP", JdeDataType.Numeric),
        new JdeField("CRCACT", "CRCACT", JdeDataType.String, 50),
        new JdeField("CRPYID", "CRPYID", JdeDataType.Numeric),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0003_0", "Primary Key on CRCO, CRVR01, CRVR02", new[] { "CRCO", "CRVR01", "CRVR02" }, isUnique: true, isPrimaryKey: true)
    };
}
