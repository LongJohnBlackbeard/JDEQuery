using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09627 - .
/// </summary>
public class F09627 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GGRECGRP.
        /// </summary>
        public const string GGRECGRP = "GGRECGRP";

        /// <summary>
        /// GGDL01.
        /// </summary>
        public const string GGDL01 = "GGDL01";

        /// <summary>
        /// GGRECRULE.
        /// </summary>
        public const string GGRECRULE = "GGRECRULE";

        /// <summary>
        /// GGGLR3FLG.
        /// </summary>
        public const string GGGLR3FLG = "GGGLR3FLG";

        /// <summary>
        /// GGPID.
        /// </summary>
        public const string GGPID = "GGPID";

        /// <summary>
        /// GGUSER.
        /// </summary>
        public const string GGUSER = "GGUSER";

        /// <summary>
        /// GGJOBN.
        /// </summary>
        public const string GGJOBN = "GGJOBN";

        /// <summary>
        /// GGUPMJ.
        /// </summary>
        public const string GGUPMJ = "GGUPMJ";

        /// <summary>
        /// GGUPMT.
        /// </summary>
        public const string GGUPMT = "GGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09627";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GGRECGRP", "GGRECGRP", JdeDataType.String, 20, true, true),
        new JdeField("GGDL01", "GGDL01", JdeDataType.String, 60),
        new JdeField("GGRECRULE", "GGRECRULE", JdeDataType.String, 20),
        new JdeField("GGGLR3FLG", "GGGLR3FLG", JdeDataType.String, 2),
        new JdeField("GGPID", "GGPID", JdeDataType.String, 20),
        new JdeField("GGUSER", "GGUSER", JdeDataType.String, 20),
        new JdeField("GGJOBN", "GGJOBN", JdeDataType.String, 20),
        new JdeField("GGUPMJ", "GGUPMJ", JdeDataType.Numeric),
        new JdeField("GGUPMT", "GGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09627_0", "Primary Key on GGRECGRP", new[] { "GGRECGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
