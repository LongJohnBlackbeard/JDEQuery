using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069067 - .
/// </summary>
public class F069067 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPCCD.
        /// </summary>
        public const string PPPCCD = "PPPCCD";

        /// <summary>
        /// PPDTEY.
        /// </summary>
        public const string PPDTEY = "PPDTEY";

        /// <summary>
        /// PPPPNB.
        /// </summary>
        public const string PPPPNB = "PPPPNB";

        /// <summary>
        /// PPPTPPBD.
        /// </summary>
        public const string PPPTPPBD = "PPPTPPBD";

        /// <summary>
        /// PPPTPPED.
        /// </summary>
        public const string PPPTPPED = "PPPTPPED";

        /// <summary>
        /// PPPTPWP.
        /// </summary>
        public const string PPPTPWP = "PPPTPWP";

        /// <summary>
        /// PPSPASUSS1.
        /// </summary>
        public const string PPSPASUSS1 = "PPSPASUSS1";

        /// <summary>
        /// PPSPASUSS2.
        /// </summary>
        public const string PPSPASUSS2 = "PPSPASUSS2";

        /// <summary>
        /// PPSPASUSS3.
        /// </summary>
        public const string PPSPASUSS3 = "PPSPASUSS3";

        /// <summary>
        /// PPSPASUSS4.
        /// </summary>
        public const string PPSPASUSS4 = "PPSPASUSS4";

        /// <summary>
        /// PPSPACUSS1.
        /// </summary>
        public const string PPSPACUSS1 = "PPSPACUSS1";

        /// <summary>
        /// PPSPACUSS2.
        /// </summary>
        public const string PPSPACUSS2 = "PPSPACUSS2";

        /// <summary>
        /// PPSPACUSS3.
        /// </summary>
        public const string PPSPACUSS3 = "PPSPACUSS3";

        /// <summary>
        /// PPSPACUSS4.
        /// </summary>
        public const string PPSPACUSS4 = "PPSPACUSS4";

        /// <summary>
        /// PPSPANUSS1.
        /// </summary>
        public const string PPSPANUSS1 = "PPSPANUSS1";

        /// <summary>
        /// PPSPANUSS2.
        /// </summary>
        public const string PPSPANUSS2 = "PPSPANUSS2";

        /// <summary>
        /// PPSPANUSS3.
        /// </summary>
        public const string PPSPANUSS3 = "PPSPANUSS3";

        /// <summary>
        /// PPSPANUSS4.
        /// </summary>
        public const string PPSPANUSS4 = "PPSPANUSS4";

        /// <summary>
        /// PPSPANUSS5.
        /// </summary>
        public const string PPSPANUSS5 = "PPSPANUSS5";

        /// <summary>
        /// PPSPANUSS6.
        /// </summary>
        public const string PPSPANUSS6 = "PPSPANUSS6";

        /// <summary>
        /// PPSPANUSS7.
        /// </summary>
        public const string PPSPANUSS7 = "PPSPANUSS7";

        /// <summary>
        /// PPSPANUSS8.
        /// </summary>
        public const string PPSPANUSS8 = "PPSPANUSS8";

        /// <summary>
        /// PPSPADUSS1.
        /// </summary>
        public const string PPSPADUSS1 = "PPSPADUSS1";

        /// <summary>
        /// PPSPADUSS2.
        /// </summary>
        public const string PPSPADUSS2 = "PPSPADUSS2";

        /// <summary>
        /// PPSPADUSS3.
        /// </summary>
        public const string PPSPADUSS3 = "PPSPADUSS3";

        /// <summary>
        /// PPSPADUSS4.
        /// </summary>
        public const string PPSPADUSS4 = "PPSPADUSS4";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";

        /// <summary>
        /// PPUPMJ.
        /// </summary>
        public const string PPUPMJ = "PPUPMJ";

        /// <summary>
        /// PPUPMT.
        /// </summary>
        public const string PPUPMT = "PPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069067";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPCCD", "PPPCCD", JdeDataType.String, 10, true, true),
        new JdeField("PPDTEY", "PPDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPPNB", "PPPPNB", JdeDataType.String, 6, true, true),
        new JdeField("PPPTPPBD", "PPPTPPBD", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPTPPED", "PPPTPPED", JdeDataType.Numeric),
        new JdeField("PPPTPWP", "PPPTPWP", JdeDataType.Numeric),
        new JdeField("PPSPASUSS1", "PPSPASUSS1", JdeDataType.String, 60),
        new JdeField("PPSPASUSS2", "PPSPASUSS2", JdeDataType.String, 60),
        new JdeField("PPSPASUSS3", "PPSPASUSS3", JdeDataType.String, 60),
        new JdeField("PPSPASUSS4", "PPSPASUSS4", JdeDataType.String, 60),
        new JdeField("PPSPACUSS1", "PPSPACUSS1", JdeDataType.String, 2),
        new JdeField("PPSPACUSS2", "PPSPACUSS2", JdeDataType.String, 2),
        new JdeField("PPSPACUSS3", "PPSPACUSS3", JdeDataType.String, 2),
        new JdeField("PPSPACUSS4", "PPSPACUSS4", JdeDataType.String, 2),
        new JdeField("PPSPANUSS1", "PPSPANUSS1", JdeDataType.Numeric),
        new JdeField("PPSPANUSS2", "PPSPANUSS2", JdeDataType.Numeric),
        new JdeField("PPSPANUSS3", "PPSPANUSS3", JdeDataType.Numeric),
        new JdeField("PPSPANUSS4", "PPSPANUSS4", JdeDataType.Numeric),
        new JdeField("PPSPANUSS5", "PPSPANUSS5", JdeDataType.Numeric),
        new JdeField("PPSPANUSS6", "PPSPANUSS6", JdeDataType.Numeric),
        new JdeField("PPSPANUSS7", "PPSPANUSS7", JdeDataType.Numeric),
        new JdeField("PPSPANUSS8", "PPSPANUSS8", JdeDataType.Numeric),
        new JdeField("PPSPADUSS1", "PPSPADUSS1", JdeDataType.Numeric),
        new JdeField("PPSPADUSS2", "PPSPADUSS2", JdeDataType.Numeric),
        new JdeField("PPSPADUSS3", "PPSPADUSS3", JdeDataType.Numeric),
        new JdeField("PPSPADUSS4", "PPSPADUSS4", JdeDataType.Numeric),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPUPMT", "PPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069067_0", "Primary Key on PPPCCD, PPDTEY, PPPPNB, PPPTPPBD", new[] { "PPPCCD", "PPDTEY", "PPPPNB", "PPPTPPBD" }, isUnique: true, isPrimaryKey: true)
    };
}
