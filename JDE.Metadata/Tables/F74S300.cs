using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S300 - .
/// </summary>
public class F74S300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHUKID.
        /// </summary>
        public const string RHUKID = "RHUKID";

        /// <summary>
        /// RHS74IDNT.
        /// </summary>
        public const string RHS74IDNT = "RHS74IDNT";

        /// <summary>
        /// RHS74NIF.
        /// </summary>
        public const string RHS74NIF = "RHS74NIF";

        /// <summary>
        /// RHS74CSV.
        /// </summary>
        public const string RHS74CSV = "RHS74CSV";

        /// <summary>
        /// RHDATE01.
        /// </summary>
        public const string RHDATE01 = "RHDATE01";

        /// <summary>
        /// RHETME.
        /// </summary>
        public const string RHETME = "RHETME";

        /// <summary>
        /// RHS74VER.
        /// </summary>
        public const string RHS74VER = "RHS74VER";

        /// <summary>
        /// RHMLN1.
        /// </summary>
        public const string RHMLN1 = "RHMLN1";

        /// <summary>
        /// RHS74CMTP.
        /// </summary>
        public const string RHS74CMTP = "RHS74CMTP";

        /// <summary>
        /// RHS74ERST.
        /// </summary>
        public const string RHS74ERST = "RHS74ERST";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";

        /// <summary>
        /// RHS74FUT01.
        /// </summary>
        public const string RHS74FUT01 = "RHS74FUT01";

        /// <summary>
        /// RHS74FUT02.
        /// </summary>
        public const string RHS74FUT02 = "RHS74FUT02";

        /// <summary>
        /// RHS74FUT03.
        /// </summary>
        public const string RHS74FUT03 = "RHS74FUT03";

        /// <summary>
        /// RHS74FUT04.
        /// </summary>
        public const string RHS74FUT04 = "RHS74FUT04";

        /// <summary>
        /// RHS74FUT05.
        /// </summary>
        public const string RHS74FUT05 = "RHS74FUT05";
    }

    /// <inheritdoc />
    public override string TableName => "F74S300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHUKID", "RHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHS74IDNT", "RHS74IDNT", JdeDataType.String, 8, true, true),
        new JdeField("RHS74NIF", "RHS74NIF", JdeDataType.String, 18, true, true),
        new JdeField("RHS74CSV", "RHS74CSV", JdeDataType.String, 60),
        new JdeField("RHDATE01", "RHDATE01", JdeDataType.Numeric),
        new JdeField("RHETME", "RHETME", JdeDataType.Numeric),
        new JdeField("RHS74VER", "RHS74VER", JdeDataType.String, 8),
        new JdeField("RHMLN1", "RHMLN1", JdeDataType.String, 80),
        new JdeField("RHS74CMTP", "RHS74CMTP", JdeDataType.String, 4),
        new JdeField("RHS74ERST", "RHS74ERST", JdeDataType.String, 40),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric),
        new JdeField("RHS74FUT01", "RHS74FUT01", JdeDataType.Numeric),
        new JdeField("RHS74FUT02", "RHS74FUT02", JdeDataType.String, 60),
        new JdeField("RHS74FUT03", "RHS74FUT03", JdeDataType.String, 2),
        new JdeField("RHS74FUT04", "RHS74FUT04", JdeDataType.String, 2),
        new JdeField("RHS74FUT05", "RHS74FUT05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S300_0", "Primary Key on RHUKID, RHS74IDNT, RHS74NIF", new[] { "RHUKID", "RHS74IDNT", "RHS74NIF" }, isUnique: true, isPrimaryKey: true)
    };
}
