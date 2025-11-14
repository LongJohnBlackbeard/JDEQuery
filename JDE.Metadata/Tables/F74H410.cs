using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H410 - .
/// </summary>
public class F74H410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAKCO.
        /// </summary>
        public const string SAKCO = "SAKCO";

        /// <summary>
        /// SADCT.
        /// </summary>
        public const string SADCT = "SADCT";

        /// <summary>
        /// SADOC.
        /// </summary>
        public const string SADOC = "SADOC";

        /// <summary>
        /// SAEXR1.
        /// </summary>
        public const string SAEXR1 = "SAEXR1";

        /// <summary>
        /// SATXA1.
        /// </summary>
        public const string SATXA1 = "SATXA1";

        /// <summary>
        /// SAVOID.
        /// </summary>
        public const string SAVOID = "SAVOID";

        /// <summary>
        /// SAAN8.
        /// </summary>
        public const string SAAN8 = "SAAN8";

        /// <summary>
        /// SADGJ.
        /// </summary>
        public const string SADGJ = "SADGJ";

        /// <summary>
        /// SADSVJ.
        /// </summary>
        public const string SADSVJ = "SADSVJ";

        /// <summary>
        /// SAH74SCRR.
        /// </summary>
        public const string SAH74SCRR = "SAH74SCRR";

        /// <summary>
        /// SAH74SSTAM.
        /// </summary>
        public const string SAH74SSTAM = "SAH74SSTAM";

        /// <summary>
        /// SAH74SATXA.
        /// </summary>
        public const string SAH74SATXA = "SAH74SATXA";

        /// <summary>
        /// SAH74SATXN.
        /// </summary>
        public const string SAH74SATXN = "SAH74SATXN";

        /// <summary>
        /// SAH74SAG.
        /// </summary>
        public const string SAH74SAG = "SAH74SAG";

        /// <summary>
        /// SASTAM.
        /// </summary>
        public const string SASTAM = "SASTAM";

        /// <summary>
        /// SAATXA.
        /// </summary>
        public const string SAATXA = "SAATXA";

        /// <summary>
        /// SAATXN.
        /// </summary>
        public const string SAATXN = "SAATXN";

        /// <summary>
        /// SAAG.
        /// </summary>
        public const string SAAG = "SAAG";

        /// <summary>
        /// SACTAM.
        /// </summary>
        public const string SACTAM = "SACTAM";

        /// <summary>
        /// SACTXA.
        /// </summary>
        public const string SACTXA = "SACTXA";

        /// <summary>
        /// SACTXN.
        /// </summary>
        public const string SACTXN = "SACTXN";

        /// <summary>
        /// SAAGF.
        /// </summary>
        public const string SAAGF = "SAAGF";

        /// <summary>
        /// SACRCD.
        /// </summary>
        public const string SACRCD = "SACRCD";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74H410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAKCO", "SAKCO", JdeDataType.String, 10, true, true),
        new JdeField("SADCT", "SADCT", JdeDataType.String, 4, true, true),
        new JdeField("SADOC", "SADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SAEXR1", "SAEXR1", JdeDataType.String, 4, true, true),
        new JdeField("SATXA1", "SATXA1", JdeDataType.String, 20, true, true),
        new JdeField("SAVOID", "SAVOID", JdeDataType.String, 2, true, true),
        new JdeField("SAAN8", "SAAN8", JdeDataType.Numeric),
        new JdeField("SADGJ", "SADGJ", JdeDataType.Numeric),
        new JdeField("SADSVJ", "SADSVJ", JdeDataType.Numeric),
        new JdeField("SAH74SCRR", "SAH74SCRR", JdeDataType.Numeric),
        new JdeField("SAH74SSTAM", "SAH74SSTAM", JdeDataType.Numeric),
        new JdeField("SAH74SATXA", "SAH74SATXA", JdeDataType.Numeric),
        new JdeField("SAH74SATXN", "SAH74SATXN", JdeDataType.Numeric),
        new JdeField("SAH74SAG", "SAH74SAG", JdeDataType.Numeric),
        new JdeField("SASTAM", "SASTAM", JdeDataType.Numeric),
        new JdeField("SAATXA", "SAATXA", JdeDataType.Numeric),
        new JdeField("SAATXN", "SAATXN", JdeDataType.Numeric),
        new JdeField("SAAG", "SAAG", JdeDataType.Numeric),
        new JdeField("SACTAM", "SACTAM", JdeDataType.Numeric),
        new JdeField("SACTXA", "SACTXA", JdeDataType.Numeric),
        new JdeField("SACTXN", "SACTXN", JdeDataType.Numeric),
        new JdeField("SAAGF", "SAAGF", JdeDataType.Numeric),
        new JdeField("SACRCD", "SACRCD", JdeDataType.String, 6),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H410_0", "Primary Key on SAKCO, SADCT, SADOC, SATXA1, SAEXR1, SAVOID", new[] { "SAKCO", "SADCT", "SADOC", "SATXA1", "SAEXR1", "SAVOID" }, isUnique: true, isPrimaryKey: true)
    };
}
