using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0690961 - .
/// </summary>
public class F0690961 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YKCO.
        /// </summary>
        public const string YKCO = "YKCO";

        /// <summary>
        /// YKPYIN.
        /// </summary>
        public const string YKPYIN = "YKPYIN";

        /// <summary>
        /// YKCSPT.
        /// </summary>
        public const string YKCSPT = "YKCSPT";

        /// <summary>
        /// YKCSMSI.
        /// </summary>
        public const string YKCSMSI = "YKCSMSI";

        /// <summary>
        /// YKCOCH01.
        /// </summary>
        public const string YKCOCH01 = "YKCOCH01";

        /// <summary>
        /// YKCOCH02.
        /// </summary>
        public const string YKCOCH02 = "YKCOCH02";

        /// <summary>
        /// YKCOCH03.
        /// </summary>
        public const string YKCOCH03 = "YKCOCH03";

        /// <summary>
        /// YKCOCH04.
        /// </summary>
        public const string YKCOCH04 = "YKCOCH04";

        /// <summary>
        /// YKCOAMT01.
        /// </summary>
        public const string YKCOAMT01 = "YKCOAMT01";

        /// <summary>
        /// YKCOAMT02.
        /// </summary>
        public const string YKCOAMT02 = "YKCOAMT02";

        /// <summary>
        /// YKCOST01.
        /// </summary>
        public const string YKCOST01 = "YKCOST01";

        /// <summary>
        /// YKCOST02.
        /// </summary>
        public const string YKCOST02 = "YKCOST02";

        /// <summary>
        /// YKCOST03.
        /// </summary>
        public const string YKCOST03 = "YKCOST03";

        /// <summary>
        /// YKCOST04.
        /// </summary>
        public const string YKCOST04 = "YKCOST04";

        /// <summary>
        /// YKCODT01.
        /// </summary>
        public const string YKCODT01 = "YKCODT01";

        /// <summary>
        /// YKCODT02.
        /// </summary>
        public const string YKCODT02 = "YKCODT02";

        /// <summary>
        /// YKUSER.
        /// </summary>
        public const string YKUSER = "YKUSER";

        /// <summary>
        /// YKPID.
        /// </summary>
        public const string YKPID = "YKPID";

        /// <summary>
        /// YKJOBN.
        /// </summary>
        public const string YKJOBN = "YKJOBN";

        /// <summary>
        /// YKUPMJ.
        /// </summary>
        public const string YKUPMJ = "YKUPMJ";

        /// <summary>
        /// YKUPMT.
        /// </summary>
        public const string YKUPMT = "YKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0690961";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YKCO", "YKCO", JdeDataType.String, 10, true, true),
        new JdeField("YKPYIN", "YKPYIN", JdeDataType.String, 2),
        new JdeField("YKCSPT", "YKCSPT", JdeDataType.String, 2),
        new JdeField("YKCSMSI", "YKCSMSI", JdeDataType.String, 2),
        new JdeField("YKCOCH01", "YKCOCH01", JdeDataType.String, 2),
        new JdeField("YKCOCH02", "YKCOCH02", JdeDataType.String, 2),
        new JdeField("YKCOCH03", "YKCOCH03", JdeDataType.String, 2),
        new JdeField("YKCOCH04", "YKCOCH04", JdeDataType.String, 2),
        new JdeField("YKCOAMT01", "YKCOAMT01", JdeDataType.Numeric),
        new JdeField("YKCOAMT02", "YKCOAMT02", JdeDataType.Numeric),
        new JdeField("YKCOST01", "YKCOST01", JdeDataType.String, 10),
        new JdeField("YKCOST02", "YKCOST02", JdeDataType.String, 10),
        new JdeField("YKCOST03", "YKCOST03", JdeDataType.String, 20),
        new JdeField("YKCOST04", "YKCOST04", JdeDataType.String, 20),
        new JdeField("YKCODT01", "YKCODT01", JdeDataType.Numeric),
        new JdeField("YKCODT02", "YKCODT02", JdeDataType.Numeric),
        new JdeField("YKUSER", "YKUSER", JdeDataType.String, 20),
        new JdeField("YKPID", "YKPID", JdeDataType.String, 20),
        new JdeField("YKJOBN", "YKJOBN", JdeDataType.String, 20),
        new JdeField("YKUPMJ", "YKUPMJ", JdeDataType.Numeric),
        new JdeField("YKUPMT", "YKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0690961_0", "Primary Key on YKCO", new[] { "YKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
