using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y050 - .
/// </summary>
public class F74Y050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THY74DYR.
        /// </summary>
        public const string THY74DYR = "THY74DYR";

        /// <summary>
        /// THY74DPN.
        /// </summary>
        public const string THY74DPN = "THY74DPN";

        /// <summary>
        /// THCO.
        /// </summary>
        public const string THCO = "THCO";

        /// <summary>
        /// THAN8.
        /// </summary>
        public const string THAN8 = "THAN8";

        /// <summary>
        /// THY74ARAP.
        /// </summary>
        public const string THY74ARAP = "THY74ARAP";

        /// <summary>
        /// THY74CTRN.
        /// </summary>
        public const string THY74CTRN = "THY74CTRN";

        /// <summary>
        /// THALPH.
        /// </summary>
        public const string THALPH = "THALPH";

        /// <summary>
        /// THY74FTAX.
        /// </summary>
        public const string THY74FTAX = "THY74FTAX";

        /// <summary>
        /// THY74FVAT.
        /// </summary>
        public const string THY74FVAT = "THY74FVAT";

        /// <summary>
        /// THY74GATX.
        /// </summary>
        public const string THY74GATX = "THY74GATX";

        /// <summary>
        /// THY74GATN.
        /// </summary>
        public const string THY74GATN = "THY74GATN";

        /// <summary>
        /// THY74GTAX.
        /// </summary>
        public const string THY74GTAX = "THY74GTAX";

        /// <summary>
        /// THY74GEXE.
        /// </summary>
        public const string THY74GEXE = "THY74GEXE";

        /// <summary>
        /// THY74GNOT.
        /// </summary>
        public const string THY74GNOT = "THY74GNOT";

        /// <summary>
        /// THY74GACU.
        /// </summary>
        public const string THY74GACU = "THY74GACU";

        /// <summary>
        /// THY74GAPR.
        /// </summary>
        public const string THY74GAPR = "THY74GAPR";

        /// <summary>
        /// THY74GACT.
        /// </summary>
        public const string THY74GACT = "THY74GACT";

        /// <summary>
        /// THY74GAPT.
        /// </summary>
        public const string THY74GAPT = "THY74GAPT";

        /// <summary>
        /// THY74SATX.
        /// </summary>
        public const string THY74SATX = "THY74SATX";

        /// <summary>
        /// THY74SATN.
        /// </summary>
        public const string THY74SATN = "THY74SATN";

        /// <summary>
        /// THY74STAX.
        /// </summary>
        public const string THY74STAX = "THY74STAX";

        /// <summary>
        /// THY74SEXE.
        /// </summary>
        public const string THY74SEXE = "THY74SEXE";

        /// <summary>
        /// THY74SNOT.
        /// </summary>
        public const string THY74SNOT = "THY74SNOT";

        /// <summary>
        /// THY74SACU.
        /// </summary>
        public const string THY74SACU = "THY74SACU";

        /// <summary>
        /// THY74SAPR.
        /// </summary>
        public const string THY74SAPR = "THY74SAPR";

        /// <summary>
        /// THY74SACT.
        /// </summary>
        public const string THY74SACT = "THY74SACT";

        /// <summary>
        /// THY74SAPT.
        /// </summary>
        public const string THY74SAPT = "THY74SAPT";

        /// <summary>
        /// THCRCD.
        /// </summary>
        public const string THCRCD = "THCRCD";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THY74DYR", "THY74DYR", JdeDataType.Numeric, null, true, true),
        new JdeField("THY74DPN", "THY74DPN", JdeDataType.Numeric, null, true, true),
        new JdeField("THCO", "THCO", JdeDataType.String, 10, true, true),
        new JdeField("THAN8", "THAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("THY74ARAP", "THY74ARAP", JdeDataType.String, 4, true, true),
        new JdeField("THY74CTRN", "THY74CTRN", JdeDataType.String, 60),
        new JdeField("THALPH", "THALPH", JdeDataType.String, 80),
        new JdeField("THY74FTAX", "THY74FTAX", JdeDataType.String, 48),
        new JdeField("THY74FVAT", "THY74FVAT", JdeDataType.String, 48),
        new JdeField("THY74GATX", "THY74GATX", JdeDataType.Numeric),
        new JdeField("THY74GATN", "THY74GATN", JdeDataType.Numeric),
        new JdeField("THY74GTAX", "THY74GTAX", JdeDataType.Numeric),
        new JdeField("THY74GEXE", "THY74GEXE", JdeDataType.Numeric),
        new JdeField("THY74GNOT", "THY74GNOT", JdeDataType.Numeric),
        new JdeField("THY74GACU", "THY74GACU", JdeDataType.Numeric),
        new JdeField("THY74GAPR", "THY74GAPR", JdeDataType.Numeric),
        new JdeField("THY74GACT", "THY74GACT", JdeDataType.Numeric),
        new JdeField("THY74GAPT", "THY74GAPT", JdeDataType.Numeric),
        new JdeField("THY74SATX", "THY74SATX", JdeDataType.Numeric),
        new JdeField("THY74SATN", "THY74SATN", JdeDataType.Numeric),
        new JdeField("THY74STAX", "THY74STAX", JdeDataType.Numeric),
        new JdeField("THY74SEXE", "THY74SEXE", JdeDataType.Numeric),
        new JdeField("THY74SNOT", "THY74SNOT", JdeDataType.Numeric),
        new JdeField("THY74SACU", "THY74SACU", JdeDataType.Numeric),
        new JdeField("THY74SAPR", "THY74SAPR", JdeDataType.Numeric),
        new JdeField("THY74SACT", "THY74SACT", JdeDataType.Numeric),
        new JdeField("THY74SAPT", "THY74SAPT", JdeDataType.Numeric),
        new JdeField("THCRCD", "THCRCD", JdeDataType.String, 6),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y050_0", "Primary Key on THY74DYR, THY74DPN, THCO, THAN8, THY74ARAP", new[] { "THY74DYR", "THY74DPN", "THCO", "THAN8", "THY74ARAP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y050_2", "Index on THY74DYR, THY74DPN, THCO, THY74CTRN, THALPH, THAN8, THY74ARAP", new[] { "THY74DYR", "THY74DPN", "THCO", "THY74CTRN", "THALPH", "THAN8", "THY74ARAP" })
    };
}
