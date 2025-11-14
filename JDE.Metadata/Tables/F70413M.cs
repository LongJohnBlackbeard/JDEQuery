using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70413M - .
/// </summary>
public class F70413M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPYID.
        /// </summary>
        public const string PPPYID = "PPPYID";

        /// <summary>
        /// PPDCTM.
        /// </summary>
        public const string PPDCTM = "PPDCTM";

        /// <summary>
        /// PPICU.
        /// </summary>
        public const string PPICU = "PPICU";

        /// <summary>
        /// PPICUT.
        /// </summary>
        public const string PPICUT = "PPICUT";

        /// <summary>
        /// PPK70IT.
        /// </summary>
        public const string PPK70IT = "PPK70IT";

        /// <summary>
        /// PPK70SER.
        /// </summary>
        public const string PPK70SER = "PPK70SER";

        /// <summary>
        /// PPK70ENUM.
        /// </summary>
        public const string PPK70ENUM = "PPK70ENUM";

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
        /// PPTDAY.
        /// </summary>
        public const string PPTDAY = "PPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F70413M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPYID", "PPPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("PPDCTM", "PPDCTM", JdeDataType.String, 4, true, true),
        new JdeField("PPICU", "PPICU", JdeDataType.Numeric, null, true, true),
        new JdeField("PPICUT", "PPICUT", JdeDataType.String, 4, true, true),
        new JdeField("PPK70IT", "PPK70IT", JdeDataType.String, 4),
        new JdeField("PPK70SER", "PPK70SER", JdeDataType.String, 40),
        new JdeField("PPK70ENUM", "PPK70ENUM", JdeDataType.String, 72),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPTDAY", "PPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70413M_0", "Primary Key on PPPYID, PPDCTM, PPICU, PPICUT", new[] { "PPPYID", "PPDCTM", "PPICU", "PPICUT" }, isUnique: true, isPrimaryKey: true)
    };
}
