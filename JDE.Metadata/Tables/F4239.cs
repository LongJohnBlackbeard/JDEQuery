using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4239 - .
/// </summary>
public class F4239 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCSHAN.
        /// </summary>
        public const string LCSHAN = "LCSHAN";

        /// <summary>
        /// LCITM.
        /// </summary>
        public const string LCITM = "LCITM";

        /// <summary>
        /// LCLLNO.
        /// </summary>
        public const string LCLLNO = "LCLLNO";

        /// <summary>
        /// LCLXDJ.
        /// </summary>
        public const string LCLXDJ = "LCLXDJ";

        /// <summary>
        /// LCSLDJ.
        /// </summary>
        public const string LCSLDJ = "LCSLDJ";

        /// <summary>
        /// LCLBDJ.
        /// </summary>
        public const string LCLBDJ = "LCLBDJ";

        /// <summary>
        /// LCLOTN.
        /// </summary>
        public const string LCLOTN = "LCLOTN";

        /// <summary>
        /// LCMMEJ.
        /// </summary>
        public const string LCMMEJ = "LCMMEJ";

        /// <summary>
        /// LCSBDJ.
        /// </summary>
        public const string LCSBDJ = "LCSBDJ";

        /// <summary>
        /// LCBBDJ.
        /// </summary>
        public const string LCBBDJ = "LCBBDJ";

        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4239";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCSHAN", "LCSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("LCITM", "LCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LCLLNO", "LCLLNO", JdeDataType.String, 60),
        new JdeField("LCLXDJ", "LCLXDJ", JdeDataType.Numeric),
        new JdeField("LCSLDJ", "LCSLDJ", JdeDataType.Numeric),
        new JdeField("LCLBDJ", "LCLBDJ", JdeDataType.Numeric),
        new JdeField("LCLOTN", "LCLOTN", JdeDataType.String, 60),
        new JdeField("LCMMEJ", "LCMMEJ", JdeDataType.Numeric),
        new JdeField("LCSBDJ", "LCSBDJ", JdeDataType.Numeric),
        new JdeField("LCBBDJ", "LCBBDJ", JdeDataType.Numeric),
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4239_0", "Primary Key on LCSHAN, LCITM", new[] { "LCSHAN", "LCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
