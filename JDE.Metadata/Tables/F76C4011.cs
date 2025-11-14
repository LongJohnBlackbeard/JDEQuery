using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C4011 - .
/// </summary>
public class F76C4011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCKCO.
        /// </summary>
        public const string VCKCO = "VCKCO";

        /// <summary>
        /// VCDOC.
        /// </summary>
        public const string VCDOC = "VCDOC";

        /// <summary>
        /// VCDCT.
        /// </summary>
        public const string VCDCT = "VCDCT";

        /// <summary>
        /// VCSFX.
        /// </summary>
        public const string VCSFX = "VCSFX";

        /// <summary>
        /// VCSFXE.
        /// </summary>
        public const string VCSFXE = "VCSFXE";

        /// <summary>
        /// VC76CAEC.
        /// </summary>
        public const string VC76CAEC = "VC76CAEC";

        /// <summary>
        /// VCTORG.
        /// </summary>
        public const string VCTORG = "VCTORG";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76C4011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCKCO", "VCKCO", JdeDataType.String, 10, true, true),
        new JdeField("VCDOC", "VCDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VCDCT", "VCDCT", JdeDataType.String, 4, true, true),
        new JdeField("VCSFX", "VCSFX", JdeDataType.String, 6, true, true),
        new JdeField("VCSFXE", "VCSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("VC76CAEC", "VC76CAEC", JdeDataType.String, 6),
        new JdeField("VCTORG", "VCTORG", JdeDataType.String, 20),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C4011_0", "Primary Key on VCKCO, VCDOC, VCDCT, VCSFX, VCSFXE", new[] { "VCKCO", "VCDOC", "VCDCT", "VCSFX", "VCSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
