using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A170 - .
/// </summary>
public class F34A170 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDMCU.
        /// </summary>
        public const string WDMCU = "WDMCU";

        /// <summary>
        /// WDMMCU.
        /// </summary>
        public const string WDMMCU = "WDMMCU";

        /// <summary>
        /// WDRESCD.
        /// </summary>
        public const string WDRESCD = "WDRESCD";

        /// <summary>
        /// WDRSETID.
        /// </summary>
        public const string WDRSETID = "WDRSETID";

        /// <summary>
        /// WDRESPRE.
        /// </summary>
        public const string WDRESPRE = "WDRESPRE";

        /// <summary>
        /// WDURCD.
        /// </summary>
        public const string WDURCD = "WDURCD";

        /// <summary>
        /// WDURDT.
        /// </summary>
        public const string WDURDT = "WDURDT";

        /// <summary>
        /// WDURAT.
        /// </summary>
        public const string WDURAT = "WDURAT";

        /// <summary>
        /// WDURAB.
        /// </summary>
        public const string WDURAB = "WDURAB";

        /// <summary>
        /// WDURRF.
        /// </summary>
        public const string WDURRF = "WDURRF";

        /// <summary>
        /// WDUSER.
        /// </summary>
        public const string WDUSER = "WDUSER";

        /// <summary>
        /// WDMKEY.
        /// </summary>
        public const string WDMKEY = "WDMKEY";

        /// <summary>
        /// WDPID.
        /// </summary>
        public const string WDPID = "WDPID";

        /// <summary>
        /// WDUUPMJ.
        /// </summary>
        public const string WDUUPMJ = "WDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F34A170";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDMCU", "WDMCU", JdeDataType.String, 24, true, true),
        new JdeField("WDMMCU", "WDMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WDRESCD", "WDRESCD", JdeDataType.String, 24, true, true),
        new JdeField("WDRSETID", "WDRSETID", JdeDataType.String, 20),
        new JdeField("WDRESPRE", "WDRESPRE", JdeDataType.Numeric),
        new JdeField("WDURCD", "WDURCD", JdeDataType.String, 4),
        new JdeField("WDURDT", "WDURDT", JdeDataType.Numeric),
        new JdeField("WDURAT", "WDURAT", JdeDataType.Numeric),
        new JdeField("WDURAB", "WDURAB", JdeDataType.Numeric),
        new JdeField("WDURRF", "WDURRF", JdeDataType.String, 30),
        new JdeField("WDUSER", "WDUSER", JdeDataType.String, 20),
        new JdeField("WDMKEY", "WDMKEY", JdeDataType.String, 30),
        new JdeField("WDPID", "WDPID", JdeDataType.String, 20),
        new JdeField("WDUUPMJ", "WDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A170_0", "Primary Key on WDMMCU, WDMCU, WDRESCD", new[] { "WDMMCU", "WDMCU", "WDRESCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A170_2", "Index on WDMMCU, WDMCU, WDRSETID", new[] { "WDMMCU", "WDMCU", "WDRSETID" })
    };
}
