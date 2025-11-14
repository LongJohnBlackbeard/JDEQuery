using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48310 - .
/// </summary>
public class F48310 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMRRTY.
        /// </summary>
        public const string RMRRTY = "RMRRTY";

        /// <summary>
        /// RMRSCN.
        /// </summary>
        public const string RMRSCN = "RMRSCN";

        /// <summary>
        /// RMDEF.
        /// </summary>
        public const string RMDEF = "RMDEF";

        /// <summary>
        /// RMEXPR.
        /// </summary>
        public const string RMEXPR = "RMEXPR";

        /// <summary>
        /// RMMMCU.
        /// </summary>
        public const string RMMMCU = "RMMMCU";

        /// <summary>
        /// RMWDCT.
        /// </summary>
        public const string RMWDCT = "RMWDCT";

        /// <summary>
        /// RMWDCK.
        /// </summary>
        public const string RMWDCK = "RMWDCK";

        /// <summary>
        /// RMSHFT.
        /// </summary>
        public const string RMSHFT = "RMSHFT";

        /// <summary>
        /// RMANSA.
        /// </summary>
        public const string RMANSA = "RMANSA";

        /// <summary>
        /// RMANPA.
        /// </summary>
        public const string RMANPA = "RMANPA";

        /// <summary>
        /// RMLANO.
        /// </summary>
        public const string RMLANO = "RMLANO";

        /// <summary>
        /// RMRSATR01.
        /// </summary>
        public const string RMRSATR01 = "RMRSATR01";

        /// <summary>
        /// RMRSATR02.
        /// </summary>
        public const string RMRSATR02 = "RMRSATR02";

        /// <summary>
        /// RMRSATR03.
        /// </summary>
        public const string RMRSATR03 = "RMRSATR03";

        /// <summary>
        /// RMRSATR04.
        /// </summary>
        public const string RMRSATR04 = "RMRSATR04";

        /// <summary>
        /// RMRSATR05.
        /// </summary>
        public const string RMRSATR05 = "RMRSATR05";

        /// <summary>
        /// RMRSATR06.
        /// </summary>
        public const string RMRSATR06 = "RMRSATR06";

        /// <summary>
        /// RMRSATR07.
        /// </summary>
        public const string RMRSATR07 = "RMRSATR07";

        /// <summary>
        /// RMRSATR08.
        /// </summary>
        public const string RMRSATR08 = "RMRSATR08";

        /// <summary>
        /// RMRSATR09.
        /// </summary>
        public const string RMRSATR09 = "RMRSATR09";

        /// <summary>
        /// RMRSATR10.
        /// </summary>
        public const string RMRSATR10 = "RMRSATR10";

        /// <summary>
        /// RMRSATR11.
        /// </summary>
        public const string RMRSATR11 = "RMRSATR11";

        /// <summary>
        /// RMRSATR12.
        /// </summary>
        public const string RMRSATR12 = "RMRSATR12";

        /// <summary>
        /// RMRSATR13.
        /// </summary>
        public const string RMRSATR13 = "RMRSATR13";

        /// <summary>
        /// RMRSATR14.
        /// </summary>
        public const string RMRSATR14 = "RMRSATR14";

        /// <summary>
        /// RMRSATR15.
        /// </summary>
        public const string RMRSATR15 = "RMRSATR15";

        /// <summary>
        /// RMRSATR16.
        /// </summary>
        public const string RMRSATR16 = "RMRSATR16";

        /// <summary>
        /// RMRSATR17.
        /// </summary>
        public const string RMRSATR17 = "RMRSATR17";

        /// <summary>
        /// RMRSATR18.
        /// </summary>
        public const string RMRSATR18 = "RMRSATR18";

        /// <summary>
        /// RMRSATR19.
        /// </summary>
        public const string RMRSATR19 = "RMRSATR19";

        /// <summary>
        /// RMRSATR20.
        /// </summary>
        public const string RMRSATR20 = "RMRSATR20";

        /// <summary>
        /// RMASAI.
        /// </summary>
        public const string RMASAI = "RMASAI";

        /// <summary>
        /// RMASNP.
        /// </summary>
        public const string RMASNP = "RMASNP";

        /// <summary>
        /// RMTIMEZONES.
        /// </summary>
        public const string RMTIMEZONES = "RMTIMEZONES";

        /// <summary>
        /// RMDSAVNAME.
        /// </summary>
        public const string RMDSAVNAME = "RMDSAVNAME";

        /// <summary>
        /// RMCALNAM.
        /// </summary>
        public const string RMCALNAM = "RMCALNAM";

        /// <summary>
        /// RMFCNM.
        /// </summary>
        public const string RMFCNM = "RMFCNM";

        /// <summary>
        /// RMWMCU.
        /// </summary>
        public const string RMWMCU = "RMWMCU";

        /// <summary>
        /// RMWORE.
        /// </summary>
        public const string RMWORE = "RMWORE";

        /// <summary>
        /// RMWORU.
        /// </summary>
        public const string RMWORU = "RMWORU";

        /// <summary>
        /// RMURCD.
        /// </summary>
        public const string RMURCD = "RMURCD";

        /// <summary>
        /// RMURDT.
        /// </summary>
        public const string RMURDT = "RMURDT";

        /// <summary>
        /// RMURAT.
        /// </summary>
        public const string RMURAT = "RMURAT";

        /// <summary>
        /// RMURAB.
        /// </summary>
        public const string RMURAB = "RMURAB";

        /// <summary>
        /// RMURRF.
        /// </summary>
        public const string RMURRF = "RMURRF";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMTDAY.
        /// </summary>
        public const string RMTDAY = "RMTDAY";

        /// <summary>
        /// RMMCULT.
        /// </summary>
        public const string RMMCULT = "RMMCULT";

        /// <summary>
        /// RMRCRW.
        /// </summary>
        public const string RMRCRW = "RMRCRW";

        /// <summary>
        /// RMDTSPN.
        /// </summary>
        public const string RMDTSPN = "RMDTSPN";
    }

    /// <inheritdoc />
    public override string TableName => "F48310";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMRRTY", "RMRRTY", JdeDataType.String, 4, true, true),
        new JdeField("RMRSCN", "RMRSCN", JdeDataType.Numeric, null, true, true),
        new JdeField("RMDEF", "RMDEF", JdeDataType.Numeric),
        new JdeField("RMEXPR", "RMEXPR", JdeDataType.Numeric),
        new JdeField("RMMMCU", "RMMMCU", JdeDataType.String, 24),
        new JdeField("RMWDCT", "RMWDCT", JdeDataType.String, 20),
        new JdeField("RMWDCK", "RMWDCK", JdeDataType.String, 20),
        new JdeField("RMSHFT", "RMSHFT", JdeDataType.String, 2),
        new JdeField("RMANSA", "RMANSA", JdeDataType.Numeric),
        new JdeField("RMANPA", "RMANPA", JdeDataType.Numeric),
        new JdeField("RMLANO", "RMLANO", JdeDataType.Numeric),
        new JdeField("RMRSATR01", "RMRSATR01", JdeDataType.String, 6),
        new JdeField("RMRSATR02", "RMRSATR02", JdeDataType.String, 6),
        new JdeField("RMRSATR03", "RMRSATR03", JdeDataType.String, 6),
        new JdeField("RMRSATR04", "RMRSATR04", JdeDataType.String, 6),
        new JdeField("RMRSATR05", "RMRSATR05", JdeDataType.String, 6),
        new JdeField("RMRSATR06", "RMRSATR06", JdeDataType.String, 6),
        new JdeField("RMRSATR07", "RMRSATR07", JdeDataType.String, 6),
        new JdeField("RMRSATR08", "RMRSATR08", JdeDataType.String, 6),
        new JdeField("RMRSATR09", "RMRSATR09", JdeDataType.String, 6),
        new JdeField("RMRSATR10", "RMRSATR10", JdeDataType.String, 6),
        new JdeField("RMRSATR11", "RMRSATR11", JdeDataType.String, 6),
        new JdeField("RMRSATR12", "RMRSATR12", JdeDataType.String, 6),
        new JdeField("RMRSATR13", "RMRSATR13", JdeDataType.String, 6),
        new JdeField("RMRSATR14", "RMRSATR14", JdeDataType.String, 6),
        new JdeField("RMRSATR15", "RMRSATR15", JdeDataType.String, 6),
        new JdeField("RMRSATR16", "RMRSATR16", JdeDataType.String, 6),
        new JdeField("RMRSATR17", "RMRSATR17", JdeDataType.String, 6),
        new JdeField("RMRSATR18", "RMRSATR18", JdeDataType.String, 6),
        new JdeField("RMRSATR19", "RMRSATR19", JdeDataType.String, 6),
        new JdeField("RMRSATR20", "RMRSATR20", JdeDataType.String, 6),
        new JdeField("RMASAI", "RMASAI", JdeDataType.String, 2),
        new JdeField("RMASNP", "RMASNP", JdeDataType.Numeric),
        new JdeField("RMTIMEZONES", "RMTIMEZONES", JdeDataType.String, 4),
        new JdeField("RMDSAVNAME", "RMDSAVNAME", JdeDataType.String, 20),
        new JdeField("RMCALNAM", "RMCALNAM", JdeDataType.String, 100),
        new JdeField("RMFCNM", "RMFCNM", JdeDataType.String, 64),
        new JdeField("RMWMCU", "RMWMCU", JdeDataType.String, 24),
        new JdeField("RMWORE", "RMWORE", JdeDataType.Numeric),
        new JdeField("RMWORU", "RMWORU", JdeDataType.Numeric),
        new JdeField("RMURCD", "RMURCD", JdeDataType.String, 4),
        new JdeField("RMURDT", "RMURDT", JdeDataType.Numeric),
        new JdeField("RMURAT", "RMURAT", JdeDataType.Numeric),
        new JdeField("RMURAB", "RMURAB", JdeDataType.Numeric),
        new JdeField("RMURRF", "RMURRF", JdeDataType.String, 30),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMTDAY", "RMTDAY", JdeDataType.Numeric),
        new JdeField("RMMCULT", "RMMCULT", JdeDataType.String, 24),
        new JdeField("RMRCRW", "RMRCRW", JdeDataType.String, 2),
        new JdeField("RMDTSPN", "RMDTSPN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48310_0", "Primary Key on RMRRTY, RMRSCN", new[] { "RMRRTY", "RMRSCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48310_2", "Index on RMRRTY, RMANPA, RMWMCU, RMRSATR01, RMRSCN", new[] { "RMRRTY", "RMANPA", "RMWMCU", "RMRSATR01", "RMRSCN" }),
        new JdeIndex("F48310_3", "Index on RMANSA, RMMCULT", new[] { "RMANSA", "RMMCULT" })
    };
}
