using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D321 - .
/// </summary>
public class F80D321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MGCFID.
        /// </summary>
        public const string MGCFID = "MGCFID";

        /// <summary>
        /// MGMGRP.
        /// </summary>
        public const string MGMGRP = "MGMGRP";

        /// <summary>
        /// MGDFYN.
        /// </summary>
        public const string MGDFYN = "MGDFYN";

        /// <summary>
        /// MGURCD.
        /// </summary>
        public const string MGURCD = "MGURCD";

        /// <summary>
        /// MGURDT.
        /// </summary>
        public const string MGURDT = "MGURDT";

        /// <summary>
        /// MGURAT.
        /// </summary>
        public const string MGURAT = "MGURAT";

        /// <summary>
        /// MGURAB.
        /// </summary>
        public const string MGURAB = "MGURAB";

        /// <summary>
        /// MGURRF.
        /// </summary>
        public const string MGURRF = "MGURRF";

        /// <summary>
        /// MGUSER.
        /// </summary>
        public const string MGUSER = "MGUSER";

        /// <summary>
        /// MGMKEY.
        /// </summary>
        public const string MGMKEY = "MGMKEY";

        /// <summary>
        /// MGPID.
        /// </summary>
        public const string MGPID = "MGPID";

        /// <summary>
        /// MGUUPMJ.
        /// </summary>
        public const string MGUUPMJ = "MGUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MGCFID", "MGCFID", JdeDataType.String, 20, true, true),
        new JdeField("MGMGRP", "MGMGRP", JdeDataType.String, 10, true, true),
        new JdeField("MGDFYN", "MGDFYN", JdeDataType.Numeric),
        new JdeField("MGURCD", "MGURCD", JdeDataType.String, 4),
        new JdeField("MGURDT", "MGURDT", JdeDataType.Numeric),
        new JdeField("MGURAT", "MGURAT", JdeDataType.Numeric),
        new JdeField("MGURAB", "MGURAB", JdeDataType.Numeric),
        new JdeField("MGURRF", "MGURRF", JdeDataType.String, 30),
        new JdeField("MGUSER", "MGUSER", JdeDataType.String, 20),
        new JdeField("MGMKEY", "MGMKEY", JdeDataType.String, 30),
        new JdeField("MGPID", "MGPID", JdeDataType.String, 20),
        new JdeField("MGUUPMJ", "MGUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D321_0", "Primary Key on MGCFID, MGMGRP", new[] { "MGCFID", "MGMGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
