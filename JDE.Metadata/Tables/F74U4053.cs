using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4053 - .
/// </summary>
public class F74U4053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DMU74ICR.
        /// </summary>
        public const string DMU74ICR = "DMU74ICR";

        /// <summary>
        /// DMU74LAN8.
        /// </summary>
        public const string DMU74LAN8 = "DMU74LAN8";

        /// <summary>
        /// DMKCO.
        /// </summary>
        public const string DMKCO = "DMKCO";

        /// <summary>
        /// DMDCT.
        /// </summary>
        public const string DMDCT = "DMDCT";

        /// <summary>
        /// DMDOC.
        /// </summary>
        public const string DMDOC = "DMDOC";

        /// <summary>
        /// DMSFX.
        /// </summary>
        public const string DMSFX = "DMSFX";

        /// <summary>
        /// DMSFXE.
        /// </summary>
        public const string DMSFXE = "DMSFXE";

        /// <summary>
        /// DMDCTM.
        /// </summary>
        public const string DMDCTM = "DMDCTM";

        /// <summary>
        /// DMAG.
        /// </summary>
        public const string DMAG = "DMAG";

        /// <summary>
        /// DMATXA.
        /// </summary>
        public const string DMATXA = "DMATXA";

        /// <summary>
        /// DMATXN.
        /// </summary>
        public const string DMATXN = "DMATXN";

        /// <summary>
        /// DMDMTJ.
        /// </summary>
        public const string DMDMTJ = "DMDMTJ";

        /// <summary>
        /// DMUKTS.
        /// </summary>
        public const string DMUKTS = "DMUKTS";

        /// <summary>
        /// DMUKTAG4.
        /// </summary>
        public const string DMUKTAG4 = "DMUKTAG4";

        /// <summary>
        /// DMUSER.
        /// </summary>
        public const string DMUSER = "DMUSER";

        /// <summary>
        /// DMPID.
        /// </summary>
        public const string DMPID = "DMPID";

        /// <summary>
        /// DMUPMJ.
        /// </summary>
        public const string DMUPMJ = "DMUPMJ";

        /// <summary>
        /// DMUPMT.
        /// </summary>
        public const string DMUPMT = "DMUPMT";

        /// <summary>
        /// DMJOBN.
        /// </summary>
        public const string DMJOBN = "DMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DMU74ICR", "DMU74ICR", JdeDataType.String, 28, true, true),
        new JdeField("DMU74LAN8", "DMU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DMKCO", "DMKCO", JdeDataType.String, 10, true, true),
        new JdeField("DMDCT", "DMDCT", JdeDataType.String, 4, true, true),
        new JdeField("DMDOC", "DMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DMSFX", "DMSFX", JdeDataType.String, 6, true, true),
        new JdeField("DMSFXE", "DMSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("DMDCTM", "DMDCTM", JdeDataType.String, 4, true, true),
        new JdeField("DMAG", "DMAG", JdeDataType.Numeric),
        new JdeField("DMATXA", "DMATXA", JdeDataType.Numeric),
        new JdeField("DMATXN", "DMATXN", JdeDataType.Numeric),
        new JdeField("DMDMTJ", "DMDMTJ", JdeDataType.Numeric),
        new JdeField("DMUKTS", "DMUKTS", JdeDataType.String, 2),
        new JdeField("DMUKTAG4", "DMUKTAG4", JdeDataType.String, 20),
        new JdeField("DMUSER", "DMUSER", JdeDataType.String, 20),
        new JdeField("DMPID", "DMPID", JdeDataType.String, 20),
        new JdeField("DMUPMJ", "DMUPMJ", JdeDataType.Numeric),
        new JdeField("DMUPMT", "DMUPMT", JdeDataType.Numeric),
        new JdeField("DMJOBN", "DMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4053_0", "Primary Key on DMU74ICR, DMU74LAN8, DMKCO, DMDCT, DMDOC, DMSFX, DMSFXE, DMDCTM", new[] { "DMU74ICR", "DMU74LAN8", "DMKCO", "DMDCT", "DMDOC", "DMSFX", "DMSFXE", "DMDCTM" }, isUnique: true, isPrimaryKey: true)
    };
}
