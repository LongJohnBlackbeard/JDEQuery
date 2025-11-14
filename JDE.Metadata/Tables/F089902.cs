using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F089902 - .
/// </summary>
public class F089902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J2CO.
        /// </summary>
        public const string J2CO = "J2CO";

        /// <summary>
        /// J2HMCU.
        /// </summary>
        public const string J2HMCU = "J2HMCU";

        /// <summary>
        /// J2TARR.
        /// </summary>
        public const string J2TARR = "J2TARR";

        /// <summary>
        /// J2EFTB.
        /// </summary>
        public const string J2EFTB = "J2EFTB";

        /// <summary>
        /// J2EFTE.
        /// </summary>
        public const string J2EFTE = "J2EFTE";

        /// <summary>
        /// J2CLTRTY.
        /// </summary>
        public const string J2CLTRTY = "J2CLTRTY";

        /// <summary>
        /// J2OBNM.
        /// </summary>
        public const string J2OBNM = "J2OBNM";

        /// <summary>
        /// J2NDYM.
        /// </summary>
        public const string J2NDYM = "J2NDYM";

        /// <summary>
        /// J2USER.
        /// </summary>
        public const string J2USER = "J2USER";

        /// <summary>
        /// J2EAP.
        /// </summary>
        public const string J2EAP = "J2EAP";

        /// <summary>
        /// J2MACH.
        /// </summary>
        public const string J2MACH = "J2MACH";

        /// <summary>
        /// J2UPMJ.
        /// </summary>
        public const string J2UPMJ = "J2UPMJ";

        /// <summary>
        /// J2UPMT.
        /// </summary>
        public const string J2UPMT = "J2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F089902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J2CO", "J2CO", JdeDataType.String, 10, true, true),
        new JdeField("J2HMCU", "J2HMCU", JdeDataType.String, 24, true, true),
        new JdeField("J2TARR", "J2TARR", JdeDataType.String, 20, true, true),
        new JdeField("J2EFTB", "J2EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("J2EFTE", "J2EFTE", JdeDataType.Numeric),
        new JdeField("J2CLTRTY", "J2CLTRTY", JdeDataType.String, 20, true, true),
        new JdeField("J2OBNM", "J2OBNM", JdeDataType.String, 20),
        new JdeField("J2NDYM", "J2NDYM", JdeDataType.Numeric),
        new JdeField("J2USER", "J2USER", JdeDataType.String, 20),
        new JdeField("J2EAP", "J2EAP", JdeDataType.String, 20),
        new JdeField("J2MACH", "J2MACH", JdeDataType.String, 24),
        new JdeField("J2UPMJ", "J2UPMJ", JdeDataType.Numeric),
        new JdeField("J2UPMT", "J2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F089902_0", "Primary Key on J2CO, J2HMCU, J2TARR, J2EFTB, J2CLTRTY", new[] { "J2CO", "J2HMCU", "J2TARR", "J2EFTB", "J2CLTRTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F089902_2", "Index on J2CO, SYS_NC00014$, SYS_NC00015$, J2TARR, J2HMCU, J2CLTRTY", new[] { "J2CO", "SYS_NC00014$", "SYS_NC00015$", "J2TARR", "J2HMCU", "J2CLTRTY" })
    };
}
