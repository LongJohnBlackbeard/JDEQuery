using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069130 - .
/// </summary>
public class F069130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDDGRP.
        /// </summary>
        public const string YDDGRP = "YDDGRP";

        /// <summary>
        /// YDEXA.
        /// </summary>
        public const string YDEXA = "YDEXA";

        /// <summary>
        /// YDGPPL.
        /// </summary>
        public const string YDGPPL = "YDGPPL";

        /// <summary>
        /// YDGMDL.
        /// </summary>
        public const string YDGMDL = "YDGMDL";

        /// <summary>
        /// YDGQDL.
        /// </summary>
        public const string YDGQDL = "YDGQDL";

        /// <summary>
        /// YDGADL.
        /// </summary>
        public const string YDGADL = "YDGADL";

        /// <summary>
        /// YDGSAL.
        /// </summary>
        public const string YDGSAL = "YDGSAL";

        /// <summary>
        /// YDGPPM.
        /// </summary>
        public const string YDGPPM = "YDGPPM";

        /// <summary>
        /// YDGPPX.
        /// </summary>
        public const string YDGPPX = "YDGPPX";

        /// <summary>
        /// YDGHMN.
        /// </summary>
        public const string YDGHMN = "YDGHMN";

        /// <summary>
        /// YDGHMX.
        /// </summary>
        public const string YDGHMX = "YDGHMX";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDDGRP", "YDDGRP", JdeDataType.String, 4, true, true),
        new JdeField("YDEXA", "YDEXA", JdeDataType.String, 60),
        new JdeField("YDGPPL", "YDGPPL", JdeDataType.Numeric),
        new JdeField("YDGMDL", "YDGMDL", JdeDataType.Numeric),
        new JdeField("YDGQDL", "YDGQDL", JdeDataType.Numeric),
        new JdeField("YDGADL", "YDGADL", JdeDataType.Numeric),
        new JdeField("YDGSAL", "YDGSAL", JdeDataType.Numeric),
        new JdeField("YDGPPM", "YDGPPM", JdeDataType.Numeric),
        new JdeField("YDGPPX", "YDGPPX", JdeDataType.Numeric),
        new JdeField("YDGHMN", "YDGHMN", JdeDataType.Numeric),
        new JdeField("YDGHMX", "YDGHMX", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069130_0", "Primary Key on YDDGRP", new[] { "YDDGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
