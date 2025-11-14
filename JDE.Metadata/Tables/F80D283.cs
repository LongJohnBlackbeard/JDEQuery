using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D283 - .
/// </summary>
public class F80D283 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCPRDJ.
        /// </summary>
        public const string OCPRDJ = "OCPRDJ";

        /// <summary>
        /// OCMCU.
        /// </summary>
        public const string OCMCU = "OCMCU";

        /// <summary>
        /// OCECBR.
        /// </summary>
        public const string OCECBR = "OCECBR";

        /// <summary>
        /// OCAOCHBK.
        /// </summary>
        public const string OCAOCHBK = "OCAOCHBK";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCMKEY.
        /// </summary>
        public const string OCMKEY = "OCMKEY";

        /// <summary>
        /// OCUTIME.
        /// </summary>
        public const string OCUTIME = "OCUTIME";

        /// <summary>
        /// OCURCD.
        /// </summary>
        public const string OCURCD = "OCURCD";

        /// <summary>
        /// OCURDT.
        /// </summary>
        public const string OCURDT = "OCURDT";

        /// <summary>
        /// OCURAT.
        /// </summary>
        public const string OCURAT = "OCURAT";

        /// <summary>
        /// OCURAB.
        /// </summary>
        public const string OCURAB = "OCURAB";

        /// <summary>
        /// OCURRF.
        /// </summary>
        public const string OCURRF = "OCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D283";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCPRDJ", "OCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("OCMCU", "OCMCU", JdeDataType.String, 24, true, true),
        new JdeField("OCECBR", "OCECBR", JdeDataType.String, 4, true, true),
        new JdeField("OCAOCHBK", "OCAOCHBK", JdeDataType.Numeric),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCMKEY", "OCMKEY", JdeDataType.String, 30),
        new JdeField("OCUTIME", "OCUTIME", JdeDataType.Date),
        new JdeField("OCURCD", "OCURCD", JdeDataType.String, 4),
        new JdeField("OCURDT", "OCURDT", JdeDataType.Numeric),
        new JdeField("OCURAT", "OCURAT", JdeDataType.Numeric),
        new JdeField("OCURAB", "OCURAB", JdeDataType.Numeric),
        new JdeField("OCURRF", "OCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D283_0", "Primary Key on OCPRDJ, OCMCU, OCECBR", new[] { "OCPRDJ", "OCMCU", "OCECBR" }, isUnique: true, isPrimaryKey: true)
    };
}
