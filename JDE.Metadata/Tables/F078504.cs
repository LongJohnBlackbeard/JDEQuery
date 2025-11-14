using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078504 - .
/// </summary>
public class F078504 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VATARA.
        /// </summary>
        public const string VATARA = "VATARA";

        /// <summary>
        /// VASCDC.
        /// </summary>
        public const string VASCDC = "VASCDC";

        /// <summary>
        /// VAPTAX.
        /// </summary>
        public const string VAPTAX = "VAPTAX";

        /// <summary>
        /// VADL01.
        /// </summary>
        public const string VADL01 = "VADL01";

        /// <summary>
        /// VADL02.
        /// </summary>
        public const string VADL02 = "VADL02";

        /// <summary>
        /// VADL03.
        /// </summary>
        public const string VADL03 = "VADL03";

        /// <summary>
        /// VADL04.
        /// </summary>
        public const string VADL04 = "VADL04";

        /// <summary>
        /// VADL05.
        /// </summary>
        public const string VADL05 = "VADL05";

        /// <summary>
        /// VADL06.
        /// </summary>
        public const string VADL06 = "VADL06";

        /// <summary>
        /// VADL07.
        /// </summary>
        public const string VADL07 = "VADL07";

        /// <summary>
        /// VADL08.
        /// </summary>
        public const string VADL08 = "VADL08";

        /// <summary>
        /// VAINT01.
        /// </summary>
        public const string VAINT01 = "VAINT01";

        /// <summary>
        /// VAINT02.
        /// </summary>
        public const string VAINT02 = "VAINT02";

        /// <summary>
        /// VAINT03.
        /// </summary>
        public const string VAINT03 = "VAINT03";

        /// <summary>
        /// VAINT04.
        /// </summary>
        public const string VAINT04 = "VAINT04";

        /// <summary>
        /// VAINT05.
        /// </summary>
        public const string VAINT05 = "VAINT05";

        /// <summary>
        /// VAMATH01.
        /// </summary>
        public const string VAMATH01 = "VAMATH01";

        /// <summary>
        /// VAMATH02.
        /// </summary>
        public const string VAMATH02 = "VAMATH02";

        /// <summary>
        /// VAMATH03.
        /// </summary>
        public const string VAMATH03 = "VAMATH03";

        /// <summary>
        /// VAMATH04.
        /// </summary>
        public const string VAMATH04 = "VAMATH04";

        /// <summary>
        /// VAMATH05.
        /// </summary>
        public const string VAMATH05 = "VAMATH05";

        /// <summary>
        /// VAUPMT.
        /// </summary>
        public const string VAUPMT = "VAUPMT";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";

        /// <summary>
        /// VAUSER.
        /// </summary>
        public const string VAUSER = "VAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F078504";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VATARA", "VATARA", JdeDataType.String, 20, true, true),
        new JdeField("VASCDC", "VASCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("VAPTAX", "VAPTAX", JdeDataType.String, 4, true, true),
        new JdeField("VADL01", "VADL01", JdeDataType.String, 60),
        new JdeField("VADL02", "VADL02", JdeDataType.String, 60),
        new JdeField("VADL03", "VADL03", JdeDataType.String, 60),
        new JdeField("VADL04", "VADL04", JdeDataType.String, 60),
        new JdeField("VADL05", "VADL05", JdeDataType.String, 60),
        new JdeField("VADL06", "VADL06", JdeDataType.String, 60),
        new JdeField("VADL07", "VADL07", JdeDataType.String, 60),
        new JdeField("VADL08", "VADL08", JdeDataType.String, 60),
        new JdeField("VAINT01", "VAINT01", JdeDataType.Numeric),
        new JdeField("VAINT02", "VAINT02", JdeDataType.Numeric),
        new JdeField("VAINT03", "VAINT03", JdeDataType.Numeric),
        new JdeField("VAINT04", "VAINT04", JdeDataType.Numeric),
        new JdeField("VAINT05", "VAINT05", JdeDataType.Numeric),
        new JdeField("VAMATH01", "VAMATH01", JdeDataType.Numeric),
        new JdeField("VAMATH02", "VAMATH02", JdeDataType.Numeric),
        new JdeField("VAMATH03", "VAMATH03", JdeDataType.Numeric),
        new JdeField("VAMATH04", "VAMATH04", JdeDataType.Numeric),
        new JdeField("VAMATH05", "VAMATH05", JdeDataType.Numeric),
        new JdeField("VAUPMT", "VAUPMT", JdeDataType.Numeric),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20),
        new JdeField("VAUSER", "VAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078504_0", "Primary Key on VATARA, VASCDC, VAPTAX", new[] { "VATARA", "VASCDC", "VAPTAX" }, isUnique: true, isPrimaryKey: true)
    };
}
